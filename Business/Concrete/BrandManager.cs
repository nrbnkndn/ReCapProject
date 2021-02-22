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

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brands.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brands.Get(p => p.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            _brands.Update(brand);
        }
    }
}
