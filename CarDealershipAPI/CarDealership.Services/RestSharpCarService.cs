using CarDealershipAPI.Domain.Abstract;
using CarDealershipAPI.Domain.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Services
{
    public class RestSharpCarService : ICarService
    {
        private readonly IRestClient _client;
        public RestSharpCarService()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["BaseCarUri"]);
        }

        public async Task<Car> GetCarAsync()
        {
            var request = new RestRequest(ConfigurationManager.AppSettings["CarsEndpoint"], Method.GET);
            var response = await _client.ExecuteTaskAsync<Car>(request);
            return response.Data;
        }
    }
}
