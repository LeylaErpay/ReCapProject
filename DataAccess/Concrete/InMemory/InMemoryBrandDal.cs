using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal: IBrandDal
    {
        List<Brands> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brands> {
            new Brands{Id=1, BrandName="Mercedes"},
            new Brands{Id=2, BrandName="Renault"},
            new Brands{Id=3, BrandName="Citreon"}
            };
        }
        public void Add(Brands obj)
        {
            _brands.Add(obj);
        }

        public void Delete(Brands obj)
        {
            _brands.Remove(_brands.SingleOrDefault(b => b.Id == obj.Id));
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            return _brands;
        }

        public void Update(Brands obj)
        {
            Brands brandToUpdate = _brands.SingleOrDefault(b => b.Id == obj.Id);
            brandToUpdate.BrandName = obj.BrandName;
        }

        public List<Brands> GetAll()
        {
            return _brands;
        }

        public Brands GetById(int id)
        {
            //Id si uyuşan markayı gönderir.
            return _brands.SingleOrDefault(b => b.Id == id);
        }
    }
}
