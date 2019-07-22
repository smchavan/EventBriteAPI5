using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class ApiPaths
    {
        public static class Event
        {
            public static string GetAllCategories(string baseUri)
            {
                return $"{baseUri}eventcategories";
            }
            public static string GetAllStates(string baseUri)
            {
                return $"{baseUri}eventstates";
            }
            public static string GetAllLocations(string baseUri)
            {
                return $"{baseUri}eventlocations";
            }
            public static string GetAllEventItems(string baseUri,
                int page, int take, int? category, int? state, int? location)
            {
                var filterQs = string.Empty;

                if (category.HasValue || state.HasValue || location.HasValue)
                {
                    var categoriesQs = (category.HasValue) ? category.Value.ToString() : "null";
                    var statesQs = (state.HasValue) ? state.Value.ToString() : "null";
                    var locationsQs = (location.HasValue) ? location.Value.ToString() : "null";
                    filterQs = $"/state/{statesQs}/category/{categoriesQs}/location/{locationsQs}";
                }

                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";

            }


        }
    }
}
