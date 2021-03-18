using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.ModelYear);
            }
            Console.WriteLine("**************************BrandManager***************************");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            Console.WriteLine("***********************ColorManager********************************");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.ColorName);
            }


            //carManager.Add(new Car { CarId = 33, Description ="Çok",DailyPrice=500,BrandId=10,ColorId=9,ModelYear=2500 });
            carManager.Update(new Car { CarId = 33, Description ="Çokkkkkkkkkkkkkkk",DailyPrice=500,BrandId=10,ColorId=9,ModelYear=2500 });
            Console.ReadKey();
        }
    }
}
