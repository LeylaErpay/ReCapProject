using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Cars>> GetAll();
        IDataResult<Cars> Get(int id);

        IResult Add(Cars car);
        IResult Update(Cars car);
        IResult Delete(Cars car);

        IDataResult<List<Cars>> GetCarsByBrandId(int id);
        //IDataResult<List<Cars>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Cars car);

    }
}
