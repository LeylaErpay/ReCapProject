using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //console sağ tık ->add->prject reference->hepsini seç
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
            
        }
    }
}
