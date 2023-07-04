using Core.Data_Access;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetail();
        List<CarDetailDto> GetCarDetailsByBrandId(int Id);
        List<CarDetailDto> GetCarDetailsByColorId(int ColorId);
    }
}
