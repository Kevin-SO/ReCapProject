using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDAL;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDAL = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            List<Rental> rentalsByCarId = _rentalDAL.GetAll(r => r.CarId == rental.CarId);
            var lastItem = rentalsByCarId.Last();

            if (lastItem.ReturnDate!=null)
            {
                _rentalDAL.Add(rental);
                return new SuccessResult("Rental added");
            }
            return new ErrorResult("Arabayı teslim alın önce gardaşşş....");

        }

        public IResult Delete(Rental rental)
        {
            _rentalDAL.Delete(rental);
            return new SuccessResult("Rental deleted");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDAL.GetAll(), "Rentals Listed");

        }
        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDAL.Get(r =>r.Id == id),"Rental listed");
        }

        public IResult Update(Rental rental)
        {
            _rentalDAL.Update(rental);
            return new SuccessResult("Rental updated");
        }
    }
}
