﻿using Entities.Concrete;
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
            //carTest();
            //brandTest();
            //brandGetByID(1);

            RentalManager rentals = new RentalManager(new EfRentalDal());
            rentals.Add(new Rental { rentDate = new DateTime(2021,02,24),  carId = 4, customerId = 2 });
            
            foreach (var rental in rentals.GetAll().Data)
            {
                Console.WriteLine("RentalID: {0} - RentDate: {1} - ReturnDate: {2} - CarID: {3} - CustomerId: {4}" ,
                     rental.rentalID, rental.rentDate, rental.ReturnDate, rental.carId, rental.customerId);
            }

        }

        private static void brandTest()
        {
            Console.WriteLine("***************BRAND****************");
            //BRAND********************************************

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine("--------------------------");

            //brandAdd(brandManager);
            //brandUpdate(brandManager);
            //brandDelete(brandManager);
            Console.WriteLine("--------------------------");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void carTest()
        {
            Console.WriteLine("**************CAR*****************");
            //BRAND********************************************
            //CAR*********************************
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetJoinDto().Data)
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

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.BrandId + " " + car.CarId + " " + car.ColorId + " " + car.DailyPrice + " " + car.Descriptions + " " + car.ModelYear);
            }
        }

        private static void brandGetByID(int brandId)
        {
            BrandManager brand1 = new BrandManager(new EfBrandDal());
            brand1.GetById(brandId);
            Console.WriteLine("GetById sonucu: "+brand1.GetById(brandId).Data.BrandName);

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
            foreach (var car in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine(car.Descriptions);
            }
        }

        private static void getCarsByBrandIdTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarsByBrandId(2).Data)
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
                ModelYear = 2000
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
                ModelYear = 2000
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
                ModelYear = 2000
            });
        }
    }
}
