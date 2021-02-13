using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //DeleteTestForCars(carManager);
            //UpdateTestForCars(carManager);

            //ColorTest();

            //BrandTest();

            //CarTest();
            //AddNewUsers();
            //AddNewCustomer();
            AddRental();
        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var rental1 = rentalManager.Add(new Rentals { CarID = 1, CustomerID = 2, RentDate = new DateTime(2021, 1, 20) , ReturnDate = new DateTime(2021, 5, 25) });
            var rental2 = rentalManager.Add(new Rentals { CarID = 4, CustomerID = 1, RentDate = new DateTime(2021, 2, 10), ReturnDate = new DateTime(2021, 6, 26) });
            
            Console.WriteLine(rental1.Message);
            Console.WriteLine(rental2.Message);
           

        }

        //private static void AddNewCustomer()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    customerManager.Add(new Customer { UserId = 2, CompanyName = "Başak Kırtasiye" });
        //    customerManager.Add(new Customer { UserId = 3, CompanyName = "Gülnar Pastanesi" });
        //    customerManager.Add(new Customer { UserId = 1, CompanyName = "Tuzcu Oto A.Ş" });
        //    Console.WriteLine("müşteriler eklendi");
        //}

        //private static void AddNewUsers()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    userManager.Add(new User { FirstName = "Ali", LastName = "Tuzcu", Email = "alituzcu@gmail.com", Password = "123456789" });
        //    userManager.Add(new User { FirstName = "Veli", LastName = "Başak", Email = "başakveli@gmail.com", Password = "asdas1234" });
        //    userManager.Add(new User { FirstName = "Fatma", LastName = "Gülnar", Email = "fatma.gülnar@yahoo.com", Password = "fatma123@" });
        //    Console.WriteLine("kullanıcılar eklendi");
        //}

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine("{0} renk", color.ColorName);
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine("{0} numaralı araç : {1} markadır. ", brand.BrandId, brand.BrandName);
        //    }
        //    //Console.WriteLine(brandManager.GetById(1).BrandName+" "+brandManager.GetById(1).ModelName);
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(" {0}  {1}  {2} renkli aracın günlük kirası {3} Türk lirasıdır.", car.BrandName, car.ModelName, car.ColorName, car.DailyPrice);
        //    }
        //    Console.WriteLine("-------------");
        //    foreach (var car1 in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine(" {0}  model Arabanın {1} Türk lirasıdır. {2}", car1.ModelName, car1.DailyPrice, car1.Description);
        //    }

        //}

        //private static void DeleteTestForCars(CarManager carManager)
        //{

        //    carManager.Delete(new Car { CarId = 9 }); //worked
        //}

        //private static void UpdateTestForCars(CarManager carManager)
        //{
        //    carManager.Update(new Car
        //    {
        //        CarId = 8,
        //        BrandId = 3,
        //        ColorId = 2,
        //        ModelYear = new DateTime(2021, 5, 12),
        //        DailyPrice = 525,
        //        Description = ("Aylık kiralanırsa fiyatta %12,5 indirim olur")

        //    });
        //}

        //private static void AddNewDataToDb()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelName = "Fluence", ModelYear = new DateTime(2015, 5, 29), DailyPrice = 250, Description = "Haftalık kiralanırsa fiyatta %10 indirim olur" });
        //    carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelName = "Passat", ModelYear = new DateTime(2020, 8, 15), DailyPrice = 500, Description = "Aylık kiralanırsa fiyatta %15 indirim olur" });
        //    carManager.Add(new Car { BrandId = 5, ColorId = 4, ModelName = "508", ModelYear = new DateTime(2021, 1, 20), DailyPrice = 700, Description = "Yıllık kiralanırsa fiyatta %12,5 indirim olur" });
        //    carManager.Add(new Car { BrandId = 4, ColorId = 3, ModelName = "320d", ModelYear = new DateTime(2017, 8, 16), DailyPrice = 600, Description = "Haftalık kiralanırsa fiyatta %10 indirim olur" });
        //    carManager.Add(new Car { BrandId = 3, ColorId = 1, ModelName = "E300", ModelYear = new DateTime(2013, 12, 10), DailyPrice = 325, Description = "Aylık kiralanırsa fiyatta %15 indirim olur" });
        //    carManager.Add(new Car { BrandId = 1, ColorId = 3, ModelName = "Megane", ModelYear = new DateTime(2015, 5, 29), DailyPrice = 450, Description = "Yıllık kiralanırsa fiyatta %16 indirim olur" });
        //    carManager.Add(new Car
        //    {
        //        BrandId = 6,
        //        ColorId = 4,
        //        ModelName = "Leon",
        //        ModelYear = new DateTime(2019, 9, 25),
        //        DailyPrice = 450,
        //        Description = "Haftalık kiralanırsa fiyatta %10 indirim olur"
        //    });
        //    carManager.Add(new Car
        //    {
        //        BrandId = 6,
        //        ColorId = 6,
        //        ModelName = "Leon",
        //        ModelYear = new DateTime(2019, 9, 25),
        //        DailyPrice = 450,
        //        Description = "Haftalık kiralanırsa fiyatta %10 indirim olur"
        //    });
        //    carManager.Add(new Car
        //    {
        //        BrandId = 6,
        //        ColorId = 3,
        //        ModelName = "Leon",
        //        ModelYear = new DateTime(2019, 9, 25),
        //        DailyPrice = 450,
        //        Description = "Haftalık kiralanırsa fiyatta %10 indirim olur"
        //    });

        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Add(new Brand { BrandName = "Renault" });
        //    brandManager.Add(new Brand { BrandName = "Wolksvagen" });
        //    brandManager.Add(new Brand { BrandName = "Mercedes" });
        //    brandManager.Add(new Brand { BrandName = "BMW" });
        //    brandManager.Add(new Brand { BrandName = "PEUGEOT" });
        //    brandManager.Add(new Brand { BrandName = "Seat" });


        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Add(new Color { ColorName = "Beyaz" });
        //    colorManager.Add(new Color { ColorName = "Siyah" });
        //    colorManager.Add(new Color { ColorName = "Gri" });
        //    colorManager.Add(new Color { ColorName = "Kırmızı" });
        //    colorManager.Add(new Color { ColorName = "Beyaz" });
        //    colorManager.Add(new Color { ColorName = "Buz Mavisi" });
        //}
    }
}
