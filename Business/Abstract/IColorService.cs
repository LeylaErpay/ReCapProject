using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Colors>> GetAll();
        IDataResult<Colors> Get(int id);
        IResult Add(Colors color);
        IResult Update(Colors color);
        IResult Delete(Colors color);
    }
}
