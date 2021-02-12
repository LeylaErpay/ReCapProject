using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //global olanları _ ile kullanırız
        List<Cars> _cars;

        public InMemoryCarDal(List<Cars> cars)
        {
            _cars = cars;
        }

        //ctor tab tab yaparsan otomatik aşağıdaki metot gelir
        public InMemoryCarDal()
        {
            _cars = new List<Cars>
            {
                //new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=1999,DailyPrice=10000,Description="BMW i8"},
                //new Car{CarId=2,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=20000,Description="BMW X5"},
                //new Car{CarId=3,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=30000,Description="Mercedes A180"},
                //new Car{CarId=4,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=40000,Description="Mercedes C180"},
            };
            
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            return _cars;
        }

        public List<Cars> GetAllCategory(int CategoryId)
        {
            return (List<Cars>)_cars.Where(c => c.CarID == CategoryId);
        }

        public void Update(Cars car)
        {
            List<Cars> _cars1 = _cars;
            Cars carToUpdate = _cars1.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.CarID = car.CarID;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public List<Cars> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAllByCategory(int BrandId)
        {
            throw new NotImplementedException();
        }

        public List<Cars> Get()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
