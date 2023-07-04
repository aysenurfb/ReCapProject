using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarDetailsByColorId(int ColorId);
        IDataResult<Car> GetCarById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int Id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
