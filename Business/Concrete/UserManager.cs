using Business.Abstract;
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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<Users> Get(int id)
        {

            return new SuccessDataResult<Users>(_userDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
