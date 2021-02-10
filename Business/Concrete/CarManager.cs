using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public List<Cars> All => throw new NotImplementedException();

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
        }
        public void Add(Cars car)
        {
            _carDal.Add(car);
        }



        public void Delete(Cars car)
        {
            _carDal.Delete(car);
        }


 
        public List<Cars> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandID == id);
        }

        public List<Cars> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorID == id);
        }

        public List<Cars> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Cars GetById(int id)
        {
            return _carDal.Get(c => c.CarID == id);
            
        }

        public List<Cars> GetByModelYear(string year)
        {
            return _carDal.GetAll(c => c.ModelYear.Contains(year) == true);
        }

        public void Update(Cars car)
        {
            _carDal.Update(car);
        }

        void ICarService.Add(Cars car)
        {
            throw new NotImplementedException();
        }

        void ICarService.Delete(Cars car)
        {
            throw new NotImplementedException();
        }

        List<Cars> ICarService.GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        List<Cars> ICarService.GetAllByColorId(int id)
        {
            throw new NotImplementedException();
        }

        List<Cars> ICarService.GetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        Cars ICarService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Cars> ICarService.GetByModelYear(string year)
        {
            throw new NotImplementedException();
        }

        void ICarService.Update(Cars car)
        {
            throw new NotImplementedException();
        }
    }
}
