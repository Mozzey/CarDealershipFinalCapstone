using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CarDealershipAPI.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealershipAPI.Data.Maps
{
    public class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            HasKey(x => x.CarID);
            Property(x => x.CarID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
