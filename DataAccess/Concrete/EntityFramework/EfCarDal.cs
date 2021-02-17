using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Cars, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetailDto { 
                                 Id = c.Id, 
                                 BrandName = b.BrandName, 
                                 ColorName = co.ColorName, 
                                 DailyPrice = c.DailyPrice, 
                                 Decription = c.Description, 
                                 ModelYear = c.ModelYear 
                             };
                return result.ToList();

            }
        }
    }
}
