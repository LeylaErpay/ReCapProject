using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositorBase<Cars,CarContext>,ICarDal
    {
        //public void Add(Cars entity)
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Cars entity)
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}



    

        //public Cars Get(Expression<Func<Cars, bool>> filter)
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        return context.Set<Cars>().SingleOrDefault(filter);
        //    }
        //}


        //public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        //{
        //    using (CarContext context = new CarContext())
        //    {

        //        return filter == null
        //                       ? context.Set<Cars>().ToList()
        //                       : context.Set<Cars>().Where(filter).ToList();
        //    }
        //}

        //public List<Cars> GetAllByCategory(int BrandID)
        //{
        //    throw new NotImplementedException();
        //}

        public List<CarDetailDTO> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.CarID equals c.BrandID
                             select new CarDetailDTO
                             {
                                 CarID = p.CarID,
                                 CarName = p.CarName,
                                 BrandName = c.BrandName
                             };
                return result.ToList();
            }
        }

        //public void Update(Cars entity)
        //{
        //    using (CarContext context = new CarContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}
