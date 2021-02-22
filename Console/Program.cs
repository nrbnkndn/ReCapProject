using Entities.Concrete;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************CAR*****************");
            //BRAND********************************************
            //CAR*********************************
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetJoinDto())
            {
                Console.WriteLine(car.CarId + " " 
                    + car.DailyPrice + " " 
                    + car.Descriptions + " " 
                    + car.ColorName + " " 
                    + car.BrandName);
            }

            Console.WriteLine("--------------------");
            //carAdd(carManager);
            //carDelete(carManager);
            //carUpdate(carManager);
            //getCarsByBrandIdTest(carManager);
            //getCarsByColorIdTest(carManager);

            Console.WriteLine("--------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId + " " + car.CarId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Descriptions + " " + car.ModelYear);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine("***************BRAND****************");
            //BRAND********************************************

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("--------------------------");

            //brandAdd(brandManager);
            //brandUpdate(brandManager);
            //brandDelete(brandManager);
            Console.WriteLine("--------------------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }

            brandGetByID(1);

            Console.WriteLine("*******************************");
            Console.WriteLine("************COLOR*******************");
            //COLOR********************************************





        }

        private static void brandGetByID(int brandId)
        {
            BrandManager brand1 = new BrandManager(new EfBrandDal());
            brand1.GetById(brandId);
            Console.WriteLine("GetById sonucu: "+brand1.GetById(brandId).BrandName);

        }

        private static void brandDelete(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { BrandId = 1002, BrandName = "Fiat12" });
        }

        private static void brandUpdate(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 1002, BrandName = "Fiat12" });
        }

        private static void brandAdd(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandName = "Fiat" });
        }

        private static void getCarsByColorIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Descriptions);
            }
        }

        private static void getCarsByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Descriptions);
            }
        }

        private static void carUpdate(CarManager carManager)
        {
            carManager.Update(new Entities.Concrete.Car
            {
                BrandId = 2,
                CarId = 1003,
                ColorId = 2,
                DailyPrice = 345,
                Descriptions = "manuel araba",
                ModelYear = "2000"
            });
        }

        private static void carAdd(CarManager carManager)
        {
            carManager.Add(new Entities.Concrete.Car
            {
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 3450,
                Descriptions = "MANUEL HATCHBACK",
                ModelYear = "2000"
            });
        }

        private static void carDelete(CarManager carManager)
        {
            carManager.Delete(new Entities.Concrete.Car
            {
                BrandId = 2,
                CarId = 2002,
                ColorId = 2,
                DailyPrice = 3450,
                Descriptions = "MANUEL HATCHBACK",
                ModelYear = "2000"
            });
        }
    }
}
