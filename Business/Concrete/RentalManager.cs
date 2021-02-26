using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;

using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rental)
        {
           
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rentals obj)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Rentals> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            try
            {
                return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(),Messages.SuccessListed);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<RentalDetailDto>>(Messages.ListedError);
            }
            
        }

        public IResult Update(Rentals obj)
        {
            throw new NotImplementedException();
        }
    }
}
