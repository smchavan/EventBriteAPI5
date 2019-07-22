using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
using WebMvc.Services;
using WebMvc.ViewModels;
namespace WebMvc.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _service;
        public EventController(IEventService service) =>
            _service = service;

        public async Task<IActionResult> Index(int? category, int? state, int? location, int? page)

        {
            var itemsOnpage = 10;
            var events = await _service.GetEventItemsAsync(page ?? 0, itemsOnpage, category, state, location);

            var vm = new EventIndexViewModel
            {
                PaginationInfo = new PaginationInfo
                {
                    ActualPage = page ?? 0,
                    ItemsPerPage = itemsOnpage,
                    TotalItems = events.Count,
                    TotalPages = (int)Math.Ceiling((decimal)events.Count/itemsOnpage)
                },

                EventItems = events.Data,

                Categories = await _service.GetCategoryAsync(),
                States = await _service.GetStateAsync(),
                Locations = await _service.GetLocationAsync(),

                CategoryFilterApplied = category ?? 0,
                StateFilterApplied = state ?? 0,
                LocationFilterApplied = location ?? 0
            };

               vm.PaginationInfo.Previous = (vm.PaginationInfo.ActualPage == 0) ? "is-disabled" : "";
               vm.PaginationInfo.Next = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalPages - 1) ? "is-disabled" : "";

               return View(vm);
       }

         /*
         [Authorize]
         public IActionResult About()
         {
          ViewData["Message"] = "Your application description page.";
          return View();
         }*/
  }
}