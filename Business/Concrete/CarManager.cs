using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public IResult Add(Car car)
        {
            if(car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                return new SuccesResult(Messages.ObjectAdded);
            }
            else
            {
                return new ErrorResult(Messages.ObjectInvalid);
            }
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ObjectListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=> p.CarId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarrDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(),Messages.ObjectListed);
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                return new SuccesResult(Messages.ObjectUpdated);
            }
            else
            {
                return new ErrorResult(Messages.ObjectInvalid);
            }
            
        }
    }
}
