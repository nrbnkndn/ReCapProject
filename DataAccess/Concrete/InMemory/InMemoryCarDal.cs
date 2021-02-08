using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=11,ColorId=111,ModelYear=1980,DailyPrice=1000,Description="80 model araba"},
                new Car{Id=2,BrandId=22,ColorId=222,ModelYear=1982,DailyPrice=1200,Description="82 model araba"},
                new Car{Id=3,BrandId=33,ColorId=333,ModelYear=1983,DailyPrice=1300,Description="83 model araba"}
            };
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);  //tek bir eleman bulmaya yarar. _cars'ı tek tek dolaşır

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id); //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul demek
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
