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
        List<Car> GetAll();
    }
}
