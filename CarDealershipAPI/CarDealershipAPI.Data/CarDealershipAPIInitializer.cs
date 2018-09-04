using CarDealershipAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipAPI.Data
{
    public class CarDealershipAPIInitializer : DropCreateDatabaseAlways<CarDealershipAPIContext>
    {
        protected override void Seed(CarDealershipAPIContext context)
        {
            context.Cars.Add(new Car()
            {
                CarID = 1,
                Make = "Ford",
                Model = "F150",
                Year = 2003,
                Color = "Maroon"
            });
            context.Cars.Add(new Car()
            {
                CarID = 2,
                Make = "Ford",
                Model = "F151",
                Year = 2004,
                Color = "Blue"
            });
            context.Cars.Add(new Car()
            {
                CarID = 3,
                Make = "Ford",
                Model = "F152",
                Year = 2005,
                Color = "Red"
            });
            context.Cars.Add(new Car()
            {
                CarID = 4,
                Make = "Ford",
                Model = "F153",
                Year = 2006,
                Color = "Yellow"
            });
            context.Cars.Add(new Car()
            {
                CarID = 5,
                Make = "Ford",
                Model = "F154",
                Year = 2007,
                Color = "Orangered"
            });
            context.Cars.Add(new Car()
            {
                CarID = 6,
                Make = "Ford",
                Model = "F155",
                Year = 2008,
                Color = "Purple"
            });
            context.Cars.Add(new Car()
            {
                CarID = 7,
                Make = "Ford",
                Model = "F156",
                Year = 2009,
                Color = "Red"
            });
            context.Cars.Add(new Car()
            {
                CarID = 8,
                Make = "Ford",
                Model = "F157",
                Year = 2010,
                Color = "Blue"
            });
            context.Cars.Add(new Car()
            {
                CarID = 9,
                Make = "Ford",
                Model = "F158",
                Year = 2011,
                Color = "Blue"
            });
            context.Cars.Add(new Car()
            {
                CarID = 10,
                Make = "Ford",
                Model = "F159",
                Year = 2012,
                Color = "Gray"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
