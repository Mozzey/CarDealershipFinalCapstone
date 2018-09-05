using CarDealership.MVC.Clients;
using CarDealership.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.MVC.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            IEnumerable<MvcCarModel> carList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Cars").Result;
            carList = response.Content.ReadAsAsync<IEnumerable<MvcCarModel>>(new List<MediaTypeFormatter>
            {
                new XmlMediaTypeFormatter(),
                new JsonMediaTypeFormatter()
            }).Result; 
            return View(carList);
        }
    }
}