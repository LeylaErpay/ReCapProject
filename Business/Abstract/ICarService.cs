using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //tüm ürünleri listelemek

        //business sağ tık->add->project referanse console hariç diğerlerinin seç
     
        IDataResult<List<Cars>> GetAll();
        IDataResult<List<Cars>> GetAllByBrandId(int id);
        IDataResult<List<Cars>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IDataResult<Cars> GetById(int carID);
        IResult Add(Cars Car);
        

        
       
        
    }
}
