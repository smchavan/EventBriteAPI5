using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }

        //public DateTime EventDate { get; set; }

        public string EventDateTime { get; set; }

        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }

        public int EventCategoryId { get; set; }
        public virtual EventCategory EventCategory { get; set; }

        public int EventStateId { get; set; }
        public virtual EventState EventState { get; set; }

        public int EventLocationId { get; set; }
        public virtual EventLocation EventLocation { get; set; }



    }
}
