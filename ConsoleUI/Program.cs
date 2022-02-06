using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EF;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.CarName+"/"+c.BrandName + "/" +c.ColorName + "/" +c.DailyPrice);
            }
            //GetById(carManager);
        }

        private static void GetById(CarManager carManager)
        {
            foreach (var c in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(c.Description);

            }
        }
    }
}
