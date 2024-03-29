﻿using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllByCarId(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(List<IFormFile> image, CarImage carImage);
        IResult DeleteAll(List<CarImage> carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile image, CarImage carImage);

    }
}
