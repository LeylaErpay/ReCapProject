using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CustomerManager : ICustomerService
    {
        public IResult Add(Customers obj)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Customers obj)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customers>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Customers> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customers obj)
        {
            throw new NotImplementedException();
        }
    }
}
