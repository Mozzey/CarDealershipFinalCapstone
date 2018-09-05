using CarDealershipAPI.Domain.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CarDealershipAPI.Clients
{
    public class CarClient
    {
        private readonly IRestClient _client;

        public CarClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["BaseCarUri"]);
        }

        public async Task<Car> GetCar()
        {
            var request = new RestRequest("Cars", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<Car>(response.Content);
        }
    }
}