using CarDealershipAPI.Domain.Abstract;
using CarDealershipAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarDealershipMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService _carService;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpGet]
        //public async Task<Car> CarList()
        //{
        //    return await _carService.GetCarAsync();
        //}
    }
}