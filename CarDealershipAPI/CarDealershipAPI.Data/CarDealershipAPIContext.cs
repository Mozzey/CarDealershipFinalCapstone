using CarDealershipAPI.Data.Maps;
using CarDealershipAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipAPI.Data
{
    public class CarDealershipAPIContext : DbContext
    {
        public CarDealershipAPIContext() : base("CarDealershipAPI")
        {
            Database.SetInitializer(new CarDealershipAPIInitializer());
        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
