using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        //car ı tanımazsa dataccess sağ tık add->projectreference->entities i seç
        //ampulden concrete ekleye seç kütüphane için
        List<Car> GetAll();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAllCategory(int CategoryId);

    }
}
