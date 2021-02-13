using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositorBase<Rentals, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rentals, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in filter is null ? context.Rentals
                                                      : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarID equals c.CarID
                             join cus in context.Customers
                             on r.CustomerID equals cus.CustomerID
                             join us in context.Users
                             on cus.UserID equals us.UserID
                             select new RentalDetailDto
                             {
                                 RentalID = r.RentalID,
                                 CarName = c.CarName,
                                 CustomerName = cus.CompanyName,
                                 CarID = c.CarID,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();

            }
        }

    }
}
