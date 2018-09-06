using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using CarDealershipAPI.Domain.Models;
using CarDealershipMVCProject.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CarDealershipMVCProject.Clients
{
    public class CarClient
    {
        private readonly IRestClient _client;

        public CarClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["CarApiBaseUri"]);
        }

        public async Task<IEnumerable<CarViewModel>> GetCars()
        {
            var request = new RestRequest("Cars", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<IEnumerable<CarViewModel>>(response.Content);
        }
    }
}