using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brands entity)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brands entity)
        {
            using (CarContext context = new CarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Brands>().SingleOrDefault(filter);
            }
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null 
                                ? context.Set<Brands>().ToList()
                                : context.Set<Brands>().Where(filter).ToList();
            }
        }

        public void Update(Brands entity)
        {
            using (CarContext context = new CarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
