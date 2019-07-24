using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Data;
using EventCatalogAPI.Domain;
using EventCatalogAPI.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        
        private readonly EventContext _context;

        private readonly IConfiguration _config;

        public EventController(EventContext context,

            IConfiguration config)

        {

            _context = context;

            _config = config;

        }



        // GET api/event/items?pageSize=10&pageIndex=2

        [HttpGet]

        [Route("[action]")]

        public async Task<IActionResult> Items(

            [FromQuery]int pageSize = 6,

            [FromQuery]int pageIndex = 0)

        {

            var itemsCount = await _context.EventItems.LongCountAsync();



            var items = await _context.EventItems

                 .OrderBy(c => c.Name)

                 .Skip(pageSize * pageIndex)

                 .Take(pageSize)

                 .ToListAsync();
            items = ChangePictureUrl(items);

            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageSize = pageSize,
                PageIndex = pageIndex,
                Count = itemsCount,
                Data = items
            };
            return Ok(model);

        }

        [HttpGet]
        [Route("[action]/category/{eventCategoryId}/state/{eventStateId}/location/{eventLocationId}")]
        public async Task<IActionResult> Items(int? eventCategoryId,
            int? eventStateId, int? eventLocationId,
            [FromQuery] int pageSize = 6,
            [FromQuery] int pageIndex = 0)
        {
            var root = (IQueryable<EventItem>)_context.EventItems;

            if (eventCategoryId.HasValue)
            {
                root = root.Where(c => c.EventCategoryId == eventCategoryId);
            }
            if (eventStateId.HasValue)
            {
                root = root.Where(c => c.EventStateId == eventStateId);
            }

            if (eventLocationId.HasValue)
            {
                root = root.Where(c => c.EventLocationId == eventLocationId);
            }

            var totalItems = await root
                              .LongCountAsync();
            var itemsOnPage = await root
                              .OrderBy(c => c.Name)
                              .Skip(pageSize * pageIndex)
                              .Take(pageSize)
                              .ToListAsync();
            itemsOnPage = ChangePictureUrl(itemsOnPage);
            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageSize = pageSize,
                PageIndex = pageIndex,
                Count = totalItems,
                Data = itemsOnPage
            };

            return Ok(model);

        }

        private List<EventItem> ChangePictureUrl(List<EventItem> items)
        {
           
        
                items.ForEach(
                    c =>
                    c.PictureUrl =
                     c.PictureUrl
                     .Replace("http://externalEventbaseurltobereplaced"
                     , _config["ExternalEventBaseUrl"]));

                return items;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventCategories()
        {
            var items = await _context.EventCategories.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Eventstates()
        {
            var items = await _context.EventStates.ToListAsync();
            return Ok(items);
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventLocations()
        {
            var items = await _context.EventLocations.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("items/{id:int}")]
        public async Task<IActionResult> GetItemsById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Incorrect Id!");
            }

            var item = await _context.EventItems
                            .SingleOrDefaultAsync(c => c.Id == id);


            if (item == null)
            {
                return NotFound("The Event item not found");
            }

            item.PictureUrl = item.PictureUrl
                 .Replace("http://externalEventbaseurltobereplaced"
                 , _config["ExternalEventBaseUrl"]);
            return Ok(item);
        }

        //GET api/Event/items/withname/Wonder?pageSize=2&pageIndex=0
        [HttpGet]
        [Route("[action]/withname/{name:minlength(1)}")]
        public async Task<IActionResult> Items(string name,
            [FromQuery] int pageSize = 6,
            [FromQuery] int pageIndex = 0)
        {
            var totalItems = await _context.EventItems
                               .Where(c => c.Name.StartsWith(name))
                              .LongCountAsync();
            var itemsOnPage = await _context.EventItems
                              .Where(c => c.Name.StartsWith(name))
                              .OrderBy(c => c.Name)
                              .Skip(pageSize * pageIndex)
                              .Take(pageSize)
                              .ToListAsync();
            itemsOnPage = ChangePictureUrl(itemsOnPage);
            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageSize = pageSize,
                PageIndex = pageIndex,
                Count = totalItems,
                Data = itemsOnPage
            };

            return Ok(model);

        }

        [HttpPost]
        [Route("items")]
        public async Task<IActionResult> CreateProduct(
            [FromBody] EventItem product)
        {
            var item = new EventItem
            {
                
                EventCategoryId = product.EventCategoryId,
                EventStateId = product.EventStateId,
                EventLocationId = product.EventLocationId,
                EventDateTime = product.EventDateTime,
                ContactName = product.ContactName,
                PhoneNumber = product.PhoneNumber,
                Description = product.Description,
                Name = product.Name,
                PictureUrl = product.PictureUrl,
                Price = product.Price
            };
            _context.EventItems.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetItemsById), new { id = item.Id });
        }


        [HttpPut]
        [Route("items")]
        public async Task<IActionResult> UpdateProduct(
            [FromBody] EventItem productToUpdate)
        {
            var eventItem = await _context.EventItems
                              .SingleOrDefaultAsync
                              (i => i.Id == productToUpdate.Id);
            if (eventItem == null)
            {
                return NotFound(new { Message = $"Item with id {productToUpdate.Id} not found." });
            }
            eventItem = productToUpdate;
            _context.EventItems.Update(eventItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetItemsById), new { id = productToUpdate.Id });
        }


        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.EventItems
                .SingleOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();

            }
            _context.EventItems.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();

        }



    }
}