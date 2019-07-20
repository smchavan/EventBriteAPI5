using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventLocation
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string StateName { get; set; }
        public string City { get; set; }


    }
}
