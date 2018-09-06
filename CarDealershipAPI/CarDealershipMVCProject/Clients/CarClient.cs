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

        public async Task<IEnumerable<Car>> GetCars()
        {
            var request = new RestRequest("Cars", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<IEnumerable<Car>>(response.Content);
        }

        public async Task<IEnumerable<Car>> SearchCars(string make, string model, int? year, string color)
        {
            var request = new RestRequest("Cars/SearchCars", Method.GET);
            request.Parameters.Add(new Parameter()
            {
                Name = "make",
                Type = ParameterType.QueryString,
                Value = make
            });
            request.Parameters.Add(new Parameter()
            {
                Name = "model",
                Type = ParameterType.QueryString,
                Value = model
            });
            if (year.HasValue)
            {
                request.Parameters.Add(new Parameter()
                {
                    Name = "year",
                    Type = ParameterType.QueryString,
                    Value = year
                });
            }
            
            request.Parameters.Add(new Parameter()
            {
                Name = "color",
                Type = ParameterType.QueryString,
                Value = color
            });

            var response = await _client.ExecuteTaskAsync(request);
            if(response.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<IEnumerable<Car>>(response.Content);
            }
            throw new Exception(response.ErrorMessage);
        }
    }
}