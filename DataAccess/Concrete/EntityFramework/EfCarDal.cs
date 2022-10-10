using Core.Data_Access.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetWithDetail()
        {
            using(ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join r in context.Colors on c.ColorId equals r.Id
                             select new CarDetailDto
                             {
                                 CarName = c.CarName,
                                 BrandName = b.Name,
                                 ColorName = r.Name,
                                 DailyPrice= c.DailyPrice,
                             };
                return result.ToList();
            }
        }
    }
}
