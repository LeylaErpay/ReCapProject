using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult< List<Cars>> GetAll()
        {
           if(DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Cars>>(Messages.ProductsListed);
            }
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(), Messages.ProductsListed);
        }
        public IResult Add(Cars car)
        {
            if(car.CarName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.ProductAdded);
        }
 
        public IDataResult<List<Cars>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>( _carDal.GetAll(c => c.BrandID == id));
        }



        public IDataResult<List<Cars>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Cars>>( _carDal.GetAll
                        (c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Cars> GetById(int carID)
        {
            return new SuccessDataResult<Cars>( _carDal.Get(c => c.CarID == carID));
            
        }


        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
           if(DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CarDetailDTO>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetails());
        }


    }
}
