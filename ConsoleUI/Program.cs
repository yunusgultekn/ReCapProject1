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
            //BrandAdd();
            //BrandDelete();
            //BrandGetAll();
            //BrandUpdate();
            //ColorAdd();
            //ColorDelete();
            //ColorGetAll();
            //ColorUpdate();
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //CarGetAll();
            //CarDetails();


            //UserManagerAll();
            //RentalManagerAll();
            //CustomerManagerAll();
        }

        private static void CustomerManagerAll()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer
            {
                UserId = 13,
                CompanyName = "Arçelik"
            });
                Console.WriteLine(result.Message);
            var result1 = customerManager.Delete(new Customer { CustomerId = 14 });
                Console.WriteLine(result1.Message);
            var result2 = customerManager.Update(new Customer { CustomerId = 15, CompanyName = "Beko", UserId = 17 });
                Console.WriteLine(result2.Message);
            var result3 = customerManager.GetAll();

            if (result3.Success == true)
            {
                foreach (var item in result3.Data)
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n", item.UserId, item.CustomerId, item.CompanyName);
                }
            }
            var result4 = customerManager.GetById(2);
            if (result4.Success == true)
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void RentalManagerAll()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            { CustomerId = 15, RentDate = new DateTime(2015,06,5), ReturnDate = new DateTime(2015, 06, 5), CarId = 14 });
                Console.WriteLine(result.Message);
            
            var result1 = rentalManager.Delete(new Rental { RentalId = 41 });

            Console.WriteLine(result1.Message);
            var result2 = rentalManager.Update(new Rental { RentalId = 42, CustomerId = 15, RentDate = new DateTime(15 / 06 / 2021), ReturnDate = new DateTime(15 / 06 / 2021), CarId = 14 });

            Console.WriteLine(result2.Message);
            var result3 = rentalManager.GetAll();

            if (result3.Success == true)
            {
                foreach (var item in result3.Data)
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", item.CarId, item.CustomerId, item.RentDate, item.ReturnDate);
                }
            }
            var result4 = rentalManager.GetById(49);
            if (result4.Success == true)
            {
               
                Console.WriteLine(result4.Message);
                Console.WriteLine(result4.Data.CustomerId);
            }
        }

        private static void UserManagerAll()
        {
            UserManager userManager = new UserManager(new EfUserDal());
             var result = userManager.Add(new User { FirstName = "Yunus", LastName = "Gültekin", Email = "asdsa@.com", Password = "151515" });
                 Console.WriteLine(result.Message);
             var result1 = userManager.Delete(new User { UserId=7 });
                 Console.WriteLine(result1.Message);
             var result2 = userManager.Update(new User { UserId = 8, FirstName = "Fatma", LastName = "Şeytan", Email = "yılannnnnn@.com", Password = "151515" });
                 Console.WriteLine(result2.Message);
             var result3 = userManager.GetAll();

            if (result3.Success == true)
            {
                foreach (var item in result3.Data)
                {
                    Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", item.FirstName, item.LastName, item.Email, item.Password);
                }
            }
            var result4 = userManager.GetById(2);
            if (result4.Success == true)
            {
                Console.WriteLine(result4.Data.FirstName);
            }
        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result5 = carManager.GetCarrDetails();
            if (result5.Success)
            {
                foreach (var dto in result5.Data)
                {
                    Console.WriteLine(dto.BrandName + "\t" + dto.ColorName + "\t" + dto.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result5.Message);
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result4 = carManager.GetAll();
            if (result4.Success)
            {
                Console.WriteLine(result4.Message);
                foreach (var car in result4.Data)
                {
                    Console.WriteLine(car.CarId + "\t" + car.BrandId + "\t" + car.ColorId + "\t" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result3 = carManager.Update(new Car { CarId = 9, BrandId = 12, DailyPrice = 599 });
            if (result3.Success)
            {
                Console.WriteLine(result3.Message);
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.Delete(new Car { CarId = 4 });
            if (result2.Success==true)
            {
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { BrandId = 7, ColorId = 8, Description = "araba araba",DailyPrice=252,  ModelYear = 2000 });
            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result4 = brandManager.Update(new Brand { BrandId = 7, BrandName = "Güzel Araba" });
            if (result4.Success==true)
            {
                Console.WriteLine(result4.Message);
            }
            else
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void BrandGetAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result3 = brandManager.GetAll();
            if (result3.Success == true)
            {
                foreach (var brand in result3.Data)
                {
                    Console.WriteLine(brand.BrandId + "\t" + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result2 = brandManager.Delete(new Brand { BrandId = 3 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result1 = brandManager.Add(new Brand { });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }



        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result4 = colorManager.Update(new Color { ColorId = 7, ColorName = "Güzel Renk" });
            if (result4.Success)
            {
                Console.WriteLine(result4.Message);
            }
            else
            {
                Console.WriteLine(result4.Message);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result3 = colorManager.GetAll();
            if (result3.Success == true)
            {
                foreach (var color in result3.Data)
                {
                    Console.WriteLine(color.ColorId + "\t" + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result3.Message);
            }
        }
        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result2 = colorManager.Delete(new Color { ColorId = 6 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }
        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result1 = colorManager.Add(new Color { ColorName = "araba" });
            if (result1.Success == true)
            {
                Console.WriteLine(result1.Message);
            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }
    }
}