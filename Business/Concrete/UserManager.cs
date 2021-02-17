using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UserManager : IUserService
    {
        public IResult Add(Users obj)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Users obj)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Users>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Users> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Users obj)
        {
            throw new NotImplementedException();
        }
    }
}
