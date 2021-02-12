using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();


            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if(result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.CarID);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
