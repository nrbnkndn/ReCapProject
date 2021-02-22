using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<JoinDto> GetJoinDto()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new JoinDto
                             {
                                 CarId = car.CarId,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 Descriptions = car.Descriptions,
                                 ColorName = color.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
