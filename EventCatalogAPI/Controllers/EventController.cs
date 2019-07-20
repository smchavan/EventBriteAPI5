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



        // GET api/catalog/items?pageSize=10&pageIndex=2

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

    }
}