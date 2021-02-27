using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Colors color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Colors color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<Colors> Get(int id)
        {
            return new SuccessDataResult<Colors>(_colorDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>>(_colorDal.GetAll());
        }

        public IResult Update(Colors color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
