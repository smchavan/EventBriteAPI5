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
                    filterQs = $"/category/{categoriesQs}/state/{statesQs}/location/{locationsQs}";
                }

                return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";

            }

        }


            public static class Basket
            {
                public static string GetBasket(string baseUri, string basketId)
                {
                    return $"{baseUri}/{basketId}";
                }

                public static string UpdateBasket(string baseUri)
                {
                    return baseUri;
                }

                public static string CleanBasket(string baseUri, string basketId)
                {
                    return $"{baseUri}/{basketId}";
                }
            }

            public static class Order
            {
                public static string GetOrder(string baseUri, string orderId)
                {
                    return $"{baseUri}/{orderId}";
                }

                //public static string GetOrdersByUser(string baseUri, string userName)
                //{
                //    return $"{baseUri}/userOrders?userName={userName}";
                //}
                public static string GetOrders(string baseUri)
                {
                    return baseUri;
                }
                public static string AddNewOrder(string baseUri)
                {
                    return $"{baseUri}/new";
                }
            }


        }
    }

