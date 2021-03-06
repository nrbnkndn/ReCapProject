﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentals)
        {
            _rentalDal = rentals;
        }

        public IResult Add(Rental rental)
        {
            //TODO- Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.
            if ((_rentalDal.Get(p => p.carId == rental.carId)) != null)
            {
                foreach (var rentals in _rentalDal.GetAll())
                {
                    if (rentals.ReturnDate == null)
                    {
                        return new ErrorResult(Messages.CarInRent);
                    }
                    _rentalDal.Add(rental);
                }
                //_rentalDal.Add(rental);
            }
        
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.rentalID == rentalId),Messages.RentalSelected);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
