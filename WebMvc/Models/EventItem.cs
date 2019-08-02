using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Models
{
    public class EventItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        public string EventDateTime { get; set; }

        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }

        public int EventCategoryId { get; set; }
        public string EventCategory { get; set; }

        public int EventStateId { get; set; }
        public string EventState { get; set; }

        public int EventLocationId { get; set; }
        public string EventLocation { get; set; }


    }
}
