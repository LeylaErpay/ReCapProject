using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //global olanları _ ile kullanırız
        List<Car> _cars;
        //ctor tab tab yaparsan otomatik aşağıdaki metot gelir
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=10000,Description="BMW i8"},
                new Car{CarId=2,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=20000,Description="BMW X5"},
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=30000,Description="Mercedes A180"},
                new Car{CarId=4,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=40000,Description="Mercedes C180"},
            };
            
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllCategory(int CategoryId)
        {
            return (List<Car>)_cars.Where(c => c.CarId == CategoryId);
        }

        public void Update(Car car)
        {
            List<Car> _cars1 = _cars;
            Car carToUpdate = _cars1.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
