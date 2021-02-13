using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brands;

        public BrandManager(IBrandDal brands)
        {
            _brands = brands;
        }

        public List<Brand> GetAll()
        {
            return _brands.GetAll();
        }
    }
}
