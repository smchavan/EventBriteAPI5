using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        
        public static void Seed(EventContext context)
        {
            context.Database.Migrate();

            if (!context.EventCategories.Any())
            {
                context.EventCategories.AddRange(GetPreConfiguredEventCategories());
                context.SaveChanges();
            }

            if (!context.EventStates.Any())
            {
                context.EventStates.AddRange(GetPreConfiguredEventStates());
                context.SaveChanges();
            }

            if (!context.EventLocations.Any())
            {
                context.EventLocations.AddRange(GetPreConfiguredEventLocations());
                context.SaveChanges();
            }

            if (!context.EventItems.Any())
            {
                context.EventItems.AddRange(GetPreConfiguredEventItems());
                context.SaveChanges();
            }

        }

        private static IEnumerable<EventItem> GetPreConfiguredEventItems()
        {
            return new List<EventItem>
            {new EventItem()
                {EventCategoryId=4,EventStateId=1, EventLocationId = 1, Name = "Arts Festival",Description = "Family fun Event", Price = 20, EventDateTime = "05/22/2009 0400PM",ContactName = "Vedant C.",
             PhoneNumber = "4438252399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/1" },

            new EventItem()
            {EventCategoryId = 7 , EventStateId = 1, EventLocationId = 3, Name = "Redmond Music Festival",Description = "Family fun Event With Live Music", Price = 50, EventDateTime = "09/05/2019 0400PM",ContactName = "Nandini C.",
             PhoneNumber = "3333352399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/2" },

            new EventItem()
            {EventCategoryId = 7 , EventStateId = 3, EventLocationId = 2, Name = "Bay Area Music Festival",Description = "Family fun Event With Live Music", Price = 80, EventDateTime = "06/05/2019 0400PM",ContactName = "Nandini C.",
             PhoneNumber = "4444442399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/3" },

            new EventItem()
            {EventCategoryId = 8 , EventStateId = 2, EventLocationId = 4, Name = "Oregon Educational Festival",Description = "Educational fun Event With Live Music", Price = 25, EventDateTime = "09/05/2019 0400PM",ContactName = "Alidi P.",
             PhoneNumber = "6666666399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/4" },

            new EventItem()
            {EventCategoryId = 5 , EventStateId = 3, EventLocationId = 2, Name = "Idaho Health Festival",Description = "Family fun Event With Health Classes", Price = 40, EventDateTime = "05/29/2019 0800AM",ContactName = "Seetha P.",
             PhoneNumber = "3333352399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/5" },

            new EventItem()
            {EventCategoryId = 3,EventStateId=1, EventLocationId = 1, Name = "TDX Seattle",Description = "Speakers Meet", Price = 30, EventDateTime = "08/22/2019 0400PM",ContactName = "Vedant C.",
             PhoneNumber = "2978645310", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/16" },

            new EventItem()
            {EventCategoryId = 2 , EventStateId = 1, EventLocationId = 2, Name = "Subaru Kids Obstacle Challenge - Seattle",Description = "Kids Event", Price = 50, EventDateTime = "29/07/2019 0400PM",ContactName = "Nandini C.",
              PhoneNumber = "3333352399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/17" },

            new EventItem()
            {EventCategoryId = 1, EventStateId = 3, EventLocationId = 2, Name = "FitFest 2019",Description = "Bring your buddies on Sunday",
                Price = 80, EventDateTime = "07/28/2019 0700AM",ContactName = "Nandini C.",
             PhoneNumber = "7053442399", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/18" },

            new EventItem()
            {EventCategoryId = 2 , EventStateId = 6, EventLocationId = 1, Name = "HELMET 30th Anniversary Tour",Description = "HELMET 30th Anniversary Tour", Price = 45, EventDateTime = "11/17/2019 01000AM",ContactName = "Alidi P.",
             PhoneNumber = "4507894563", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/19" },

            new EventItem()
            {EventCategoryId = 3 , EventStateId = 1, EventLocationId = 1, Name = "TruffleCon 2019 | Blockchain Developer Conference",Description = "TruffleCon is a gathering for Truffle users, fans, developers", Price = 40, EventDateTime = "08/02/2019 0800AM",ContactName = "Seetha P.",
             PhoneNumber = "6789034521", PictureUrl = "http://externalEventbaseurltobereplaced/api/pic/20" }
            };

             

        }

        private static IEnumerable<EventLocation> GetPreConfiguredEventLocations()
        {
            return new List<EventLocation>
            {
                new EventLocation() { City = "Redmond", LocationName = "Redmond Downtown",Address = "1655 NE 14th Pl",StateName = "Washington"},
                 new EventLocation() { City = "Seattle", LocationName = "Seattle Downtown",Address = "645 NW 45th St",StateName = "Washington"},
                 new EventLocation() { City = "Bellevue", LocationName = "Bahai Center",Address = "1655 NE 14th Pl",StateName = "Washington"},
                new EventLocation() { City = "Redmond", LocationName = "Rosa Park Arts and performance Center",Address = "550 E Main St",StateName = "Washington"},
                new EventLocation() { City = "San Fransisco", LocationName = "Spiritual Center of Bay area", Address = "330 Lincoln Street",StateName = "California"},
                new EventLocation() { City = "San Mateo", LocationName = "Biggest Event Center",Address = "990 E Marginal Way ",StateName = "California"}

            };

        }

        private static IEnumerable<EventState> GetPreConfiguredEventStates()
        {
            return new List<EventState>()
            {
                new EventState() {State = "Colorodo"},
                new EventState() {State = "Washington"},
                new EventState() {State = "Oregon"},
                new EventState() {State = "California"},
                new EventState() {State = "Idaho"},
                new EventState() {State = "Nevada"},
                new EventState() {State = "Texas"},
                new EventState() {State = "Arizona"},
                new EventState() {State = "New Mexico"},
                new EventState() {State = "Utah"},
                new EventState() {State = "colorado"},
                new EventState() {State = "New York"},
                new EventState() {State = "Boston"},
                new EventState() {State = "Florida"},

            };
        }

        private static IEnumerable<EventCategory> GetPreConfiguredEventCategories()
        {
            return new List<EventCategory>()
            {new EventCategory() {Category = "kids"},
                new EventCategory() {Category = "states event"},
                 new EventCategory() {Category = "Technology"},
                new EventCategory() {Category = "Music"},
                new EventCategory() {Category = "Health"},
                new EventCategory() {Category = "Fashion"},
                new EventCategory() {Category = "Family"},
                new EventCategory() {Category = "Education"},
                new EventCategory() {Category = "Charity"}
                

            };
        }
    }
}
