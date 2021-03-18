using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager: IBrandService 
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brands brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brands brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<Brands> Get(int id)
        {
            return new SuccessDataResult<Brands>(_brandDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Brands>> GetAll()
        {
            return new SuccessDataResult<List<Brands>>(_brandDal.GetAll());
        }

        public IDataResult<Brands> GetById(int brandId)
        {
            return new SuccessDataResult<Brands>(_brandDal.Get(c => c.Id == brandId));
        }

        public IResult Update(Brands brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult();
        }




    }
}
