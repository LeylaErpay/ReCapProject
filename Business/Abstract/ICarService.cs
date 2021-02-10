using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        //tüm ürünleri listelemek

        //business sağ tık->add->project referanse console hariç diğerlerinin seç
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);
        List<Cars> All { get; }

        Cars GetById(int id);
        List<Cars> GetAllByColorId(int id);
        List<Cars> GetAllByBrandId(int id);
        List<Cars> GetByDailyPrice(decimal min, decimal max);
        List<Cars> GetByModelYear(string year);
    }
}
