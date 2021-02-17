using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal: EfEntityRepositoryBase<Rentals, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars on rent.CarId equals car.Id
                             join customer in context.Customers on rent.CustomerId equals customer.Id
                             join user in context.Users on customer.UserId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             select new RentalDetailDto
                             {
                                 Id = rent.Id,
                                 CarId = car.Id,
                                 UserName = user.FirstName + " " + user.LastName,
                                 CustomerName = customer.CompanyName,
                                 BrandName=brand.BrandName,
                                 ModelYear=car.ModelYear,
                                 ColorName=color.ColorName,
                                 DailyPrice=car.DailyPrice,      
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate
                                 
                             };

                return result.ToList();

            }
        }
    }
}

