using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebMvc.Infrastructure;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class EventService : IEventService
    {
        private readonly IHttpClient _client;
        private readonly string _baseUri;

        public EventService(IHttpClient httpclient,
            IConfiguration config)
        {
            _client = httpclient;
            _baseUri = $"{config["EventUrl"]}/api/event/";// _baseUri = $"{config["CatalogUrl"]}/api/catalog/";
        }
        public async Task<IEnumerable<SelectListItem>> GetCategoryAsync()
        {
            var categoryUri = ApiPaths.Event.GetAllCategories(_baseUri);
            var dataString = await _client.GetStringAsync(categoryUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value=null,
                    Text="All",
                    Selected = true
                }
            };

            var categories = JArray.Parse(dataString);//JsonConvert.DeserializeObject<MyDTO>(input);
            foreach (var category in categories)
            {
                items.Add(
                    new SelectListItem
                    {
                        Value = category.Value<string>("id"),
                        Text = category.Value<string>("category")
                    }
                 );
            }

            return items;
        }

        public async Task<Event> GetEventItemsAsync(int page, int size, int? category, int? state, int? locationName)
        {
            var eventItemsUri = ApiPaths.Event
                            .GetAllEventItems(_baseUri,
                                page, size, category,state,locationName);

            var dataString = await _client.GetStringAsync(eventItemsUri);
            var response = JsonConvert.DeserializeObject<Event>(dataString);
            return response;
        }

        public async Task<IEnumerable<SelectListItem>> GetLocationAsync()
        {
            var locationUri = ApiPaths.Event.GetAllLocations(_baseUri);
            var dataString = await _client.GetStringAsync(locationUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value=null,
                    Text="All",
                    Selected = true
                }
            };
            
            var locations = JArray.Parse(dataString);
            foreach (var location in locations)
            {
                items.Add(
                    new SelectListItem
                    {
                        Value = location.Value<string>("id"),
                        Text = location.Value<string>("locationName")
                    }
                 );
            }

            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetStateAsync()
        {
            var stateUri = ApiPaths.Event.GetAllStates(_baseUri);
            var dataString = await _client.GetStringAsync(stateUri);
            var items = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value=null,
                    Text="All",
                    Selected = true
                }
            };

            var states = JArray.Parse(dataString);
            foreach (var state in states)
            {
                items.Add(
                    new SelectListItem
                    {
                        Value = state.Value<string>("id"),
                        Text = state.Value<string>("state")
                    }
                 );
            }

            return items;
        }



    }

        
 }

