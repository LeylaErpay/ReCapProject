using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;

using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Colors obj)
        {
            if (_colorDal.Get(c => c.Id == obj.Id) != null)
            {
                return new ErrorResult(Messages.AddedError);
            }
            _colorDal.Add(obj);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Colors obj)
        {
            //Burada UI dan gelen rengin id'si ile DataAccess'de id'si uyuşan renk olup olmadığı kontrol ediliyor.
            if (_colorDal.Get(c => c.Id == obj.Id)==null)
            {
                return new ErrorResult(Messages.IdError);
            }
            _colorDal.Delete(obj);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>>(_colorDal.GetAll(), Messages.ColorListed);
        }

        public IDataResult<Colors> GetById(int id)
        {
            return new SuccessDataResult<Colors>(_colorDal.Get(c => c.Id == id));
        }

        public IResult Update(Colors obj)
        {
            _colorDal.Update(obj);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
