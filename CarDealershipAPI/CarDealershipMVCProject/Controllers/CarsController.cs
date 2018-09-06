using CarDealershipMVCProject.Clients;
using CarDealershipMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CarDealershipMVCProject.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarClient _client;

        public CarsController()
        {
            _client = new CarClient();
        }

        public async Task<ActionResult> GetCars()
        {
            var cars = await _client.GetCars();
            return View(cars);
        }

        public async Task<ActionResult> SearchCars(string make, string model, int? year, string color)
        {
            var cars = await _client.SearchCars(make, model, year, color);
            return View(cars);
        }

        // GET: Cars
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public Task<ActionResult> Index(string make, string model, int? year, string color)
        //{
            
        //}

        // GET: Cars/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cars/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cars/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
