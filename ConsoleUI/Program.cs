using Business.Concrate;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Core.Utilities.Results;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
                  
           // RentalAdd(rentalManager);       
        }

        //private static void RentalAdd(RentalManager rentalManager)
        //{
        //    var addedResult = rentalManager.Add(new Rentals
        //    { CustomerId = 1, CarId = 3, RentDate = DateTime.Now });
        //    Console.WriteLine(addedResult.Message);
        //}  
    }
}
