using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> Get(int id);
        IResult Add(Users user);
        IResult Delete(Users user);
        IResult Update(Users user);
    }
}
