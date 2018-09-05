using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CarDealershipAPI.Data;
using CarDealershipAPI.Domain.Models;

namespace CarDealershipAPI.Controllers
{
    public class CarsController : ApiController
    {
        private CarDealershipAPIContext db = new CarDealershipAPIContext();

        // GET: api/Cars
        //public IQueryable<Car> GetCars()
        //{
        //    return db.Cars;
        //}

        public List<Car> GetCars(int? year = null, string make = null, string model = null, string color = null)
        {
            var cars = db.Cars.AsQueryable();
            if(year.HasValue)
            {
                cars = cars.Where(x => x.Year == year);
            }
            if (!string.IsNullOrWhiteSpace(color))
            {
                cars = cars.Where(x => x.Color == color);
            }
            if (!string.IsNullOrWhiteSpace(model))
            {
                cars = cars.Where(x => x.Model == model);
            }
            if (!string.IsNullOrWhiteSpace(make))
            {
                cars = cars.Where(x => x.Make == make);
            }
            return cars.ToList();
        }

        // GET: api/Cars/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult GetCar(int id)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        // PUT: api/Cars/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCar(int id, Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.CarID)
            {
                return BadRequest();
            }

            db.Entry(car).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cars
        [ResponseType(typeof(Car))]
        public IHttpActionResult PostCar(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cars.Add(car);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = car.CarID }, car);
        }

        // DELETE: api/Cars/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult DeleteCar(int id)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            db.Cars.Remove(car);
            db.SaveChanges();

            return Ok(car);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarExists(int id)
        {
            return db.Cars.Count(e => e.CarID == id) > 0;
        }
    }
}