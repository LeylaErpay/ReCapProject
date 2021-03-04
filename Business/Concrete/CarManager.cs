using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;
        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService= brandService;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Cars car)
        {

            IResult result = BusinessRules.Run(CheckIfCarNameExists(car.CarName),
            CheckIfCarCountOfCategoryCorrect(car.BrandId), CheckIfBrandLimitExceded());

            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Cars car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Cars car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<Cars> Get(int id)
        {
            return new SuccessDataResult<Cars>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Cars>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Cars>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        private IResult CheckIfCarCountOfCategoryCorrect(int categoryId)
        {
            //Select count(*) from products where categoryId=1
            var result = _carDal.GetAll(p => p.BrandId == categoryId).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.CarCountOfCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarNameExists(string productName)
        {
            var result = _carDal.GetAll(p => p.CarName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfBrandLimitExceded()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.BrandLimitExceded);
            }

            return new SuccessResult();
        }

    }
}
