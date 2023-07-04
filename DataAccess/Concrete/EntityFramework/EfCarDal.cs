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
        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 CarName = car.CarName,
                                 BrandId = b.Id,
                                 ColorId = c.ColorId,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from ci in context.CarImages where ci.CarId == car.Id select ci.ImagePath).FirstOrDefault()
                             };

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int Id)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             where b.Id == Id
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 CarName = b.Name,
                                 BrandId = b.Id,
                                 ColorId = c.ColorId,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from ci in context.CarImages where car.Id == ci.CarId select ci.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int ColorId)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             where c.ColorId == ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 CarName= b.Name,
                                 BrandId = b.Id,
                                 ColorId = c.ColorId,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 Description = car.Description,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 ImagePath = (from ci in context.CarImages where car.Id == ci.CarId select ci.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }
    }
}
