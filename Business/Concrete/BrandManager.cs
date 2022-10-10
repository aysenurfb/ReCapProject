using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;
        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _iBrandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_iBrandDal.Get(p => p.Id == id));
        }

        public IDataResult<Brand> GetByName(string name)
        {
            return new SuccessDataResult<Brand>(_iBrandDal.Get(p => p.Name == name));
        }

        public IResult Update(Brand brand)
        {
            _iBrandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
