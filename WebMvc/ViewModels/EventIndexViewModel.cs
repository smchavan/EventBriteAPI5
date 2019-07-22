using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.ViewModels
{
    public class EventIndexViewModel
    {
        public PaginationInfo PaginationInfo { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<SelectListItem> States { get; set; }
        public IEnumerable<SelectListItem> Locations { get; set; }
        public IEnumerable<EventItem> EventItems { get; set; }

        public int? CategoryFilterApplied { get; set; }
        public int? StateFilterApplied { get; set; }
        public int? LocationFilterApplied { get; set; }
    }
}
