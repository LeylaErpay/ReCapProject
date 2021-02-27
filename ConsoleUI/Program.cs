using Business.Concrete;
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
            // CarManager carManager = new CarManager(new EfCarDal());
            // RentalManager rentalManager = new RentalManager(new EfRentalDal());                  
            // RentalAdd(rentalManager);     
            //CarTest();
        }
        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal()
        //        , new BrandManager(new EfBrandDal()));

        //    var result = carManager.GetCarDetails();

        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName + "/" + car.BrandId);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }


        //}

        //private static void RentalAdd(RentalManager rentalManager)
        //{
        //    var addedResult = rentalManager.Add(new Rentals
        //    { CustomerId = 1, CarId = 3, RentDate = DateTime.Now });
        //    Console.WriteLine(addedResult.Message);
        //}  
    }
}
