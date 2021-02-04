using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorApp1.Data;
using Newtonsoft.Json;

namespace BlazorApp1.Services
{
    public class WebPortalService : IWebPortal
    {
        private readonly HttpClient httpClient;

        public WebPortalService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<OrderDetails>> GetAllOrder()
        {
            var list = new List<OrderDetails>();
            var holder = await httpClient.GetAsync("api/orders/all");
            string jsonContent = holder.Content.ReadAsStringAsync().Result;
            list = JsonConvert.DeserializeObject<List<OrderDetails>>(jsonContent);
            return list;
        }
    }
}
