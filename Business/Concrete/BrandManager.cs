using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            _brands.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brands.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brands.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brands.Get(p => p.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            _brands.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

    }
}
