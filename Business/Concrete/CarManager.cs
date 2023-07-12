using Core.Utilities;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal carDal)
        {
            _icarDal= carDal;
        }


        [ValidationAspect(typeof(CarValidator))]
        [CacheAspect]
        public IResult Add(Car car)
        {
            _icarDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _icarDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(),Messages.CarListed); 
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_icarDal.GetCarDetail().ToList(),Messages.CarListedWDetail);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int Id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_icarDal.GetCarDetailsByBrandId(Id), Messages.CarListedWDetail);
        }

        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_icarDal.Get(p => p.Id == id),Messages.CarListed);
        }


        public IDataResult<List<Car>> GetCarDetailsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll(p => p.ColorId == ColorId));
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _icarDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            return new ErrorResult(Messages.CarNotUpdated);
        }
    }
}
