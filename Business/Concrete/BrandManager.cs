using Business.Abstract;
using Business.Constant;
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

        public IResult Add(Brands obj)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Brands obj)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brands>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brands> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Brands obj)
        {
            throw new NotImplementedException();
        }

        //public IResult Add(Brands obj)
        //{
        //    if (obj.BrandName.Length < 2)
        //    {
        //        new ErrorResult(Messages.BrandAdded);
        //    }
        //    _brandDal.Add(obj);
        //    return new SuccessResult(Messages.BrandAdded);
        //}

        //public IResult Delete(Brands obj)
        //{
        //    _brandDal.Delete(obj);
        //    return new SuccessResult(Messages.BrandDeleted);
        //}

        //public IDataResult<List<Brands>> GetAll()
        //{
        //    return new SuccessDataResult<List<Brands>>(_brandDal.GetAll());
        //}

        //public IDataResult<Brands> GetById(int id)
        //{
        //    //Burada id'leri uyuşan marka var ise brandResult'a atanıyor.
        //    var brandResult = _brandDal.Get(b => b.Id == id);
        //    if (brandResult==null)
        //    {
        //        //Eğer brandResult null ise geriye hata gönderiliyor.
        //        return new ErrorDataResult<Brands>(Messages.ListedError);
        //    }
        //    //if çalışmaz ise id'si uyuşan marka geri gönderiliyor.
        //    return new SuccessDataResult<Brands>(brandResult);
        //}

        //public IResult Update(Brands obj)
        //{
        //    _brandDal.Update(obj);
        //    return new SuccessResult(Messages.BrandUpdated);
        //}
    }
}
