using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Colors> _color;
        public InMemoryColorDal()
        {
            _color = new List<Colors> {
            new Colors{Id=1, ColorName="Beyaz"},
            new Colors{Id=2, ColorName="Mavi"},
            new Colors{Id=3, ColorName="Siyah"}
            };
        }
        public void Add(Colors obj)
        {
            _color.Add(obj);
        }


        public void Delete(Colors obj)
        {
            _color.Remove(_color.SingleOrDefault(c=>c.Id==obj.Id));
        }     

        public void Update(Colors obj)
        {
            Colors brandToUpdate = _color.SingleOrDefault(c => c.Id == obj.Id);
            brandToUpdate.ColorName = obj.ColorName;
        }

        public List<Colors> GetAll()
        {
            return _color;
        }
        public Colors GetById(int id)
        {
            return _color.SingleOrDefault(c => c.Id == id);
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            return null;
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            return null;
        }
    }
}
