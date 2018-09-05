using CarDealershipAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipAPI.Domain.Abstract
{
    public interface ICarService
    {
        Task<Car> GetCarAsync();
    }
}
