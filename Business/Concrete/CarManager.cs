using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
         //ampulden generate constructor dersen aşağıdakiler otomatik gelir injection
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();

            //InMemoryCarDal inMemoryCarDal =new InMemoryCarDal(); yazarsan tek tek değiştirmke zorunda kalırsın
        }
    }
}
