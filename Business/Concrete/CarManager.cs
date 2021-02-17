using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }
        public IResult Add(Cars obj)
        {
            _carDal.Add(obj);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Cars obj)
        {
            if (DateTime.Now.Hour==00)
            {
                return new ErrorResult(Messages.AddedError);
            }
            _carDal.Delete(obj);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Cars>> GetAllByModelYear(short year)
        {
            if (year < 1990 || year > 2021)
            {
                return new ErrorDataResult<List<Cars>>(Messages.ListedError);
            }
            var getAllByModel = _carDal.GetAll(c => c.ModelYear == year);
            return new SuccessDataResult<List<Cars>>(getAllByModel);
        }

        public IDataResult<List<Cars>> GetAllBrandId(int brandId)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c=> c.BrandId==brandId));
        }

        public IDataResult<Cars> GetById(int id)
        {
            return new SuccessDataResult<Cars>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Cars>> GetAllColorId(int colorId)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c=>c.ColorId==colorId));
        }

        public IResult Update(Cars obj)
        {
            return new SuccessDataResult<Cars>(Messages.CarAdded);
        }
    }
}
