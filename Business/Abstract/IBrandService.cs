using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brands>> GetAll();
        IDataResult<Brands> GetById(int colorId);
        IDataResult<Brands> Get(int id);
        IResult Add(Brands brand);
        IResult Update(Brands brand);
        IResult Delete(Brands brand);
    }
}
