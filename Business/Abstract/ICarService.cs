using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Cars>> GetAll();
        //IDataResult<List<Cars>> GetAllBrandId(int brandId);
        //IDataResult<List<Cars>> GetAllColorId(int colorId);
      //  IDataResult<List<Cars>> GetAllByModelYear(int year);
      //  IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Cars car);
       
    }
}
