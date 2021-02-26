using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Cars> {
            new Cars{Id=1, BrandId=1, ColorId=1, DailyPrice=25000, ModelYear=2002, Descriptions="Hiç bir sorunu yoktur."},
            new Cars{Id=2, BrandId=1, ColorId=2, DailyPrice=38000, ModelYear=2007, Descriptions="Ağır kazası vardır"},
            new Cars{Id=3, BrandId=2, ColorId=1, DailyPrice=55000, ModelYear=2011, Descriptions="Dosta gider."},
            new Cars{Id=4, BrandId=3, ColorId=3, DailyPrice=19000, ModelYear=1998, Descriptions="Komple boyalı."},
            new Cars{Id=5, BrandId=2, ColorId=2, DailyPrice=175000, ModelYear=2021, Descriptions="Sıfır araba."},
            };
        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars obj)
        {
            _cars.Remove(_cars.SingleOrDefault(c=> c.Id==obj.Id));
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }       

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            return _cars;
        }        

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public Cars GetById(int id)
        {
            //Id si uyuşan arabayı gönderir.
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
