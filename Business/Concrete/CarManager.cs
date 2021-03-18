using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            if(car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Ekleme Başarılı");
            }
            else
            {
                Console.WriteLine("Kurallara Uygun Davranın");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllBrandId(int id)
        {
            return _carDal.GetAllBrandId(id);
        }

        public List<Car> GetAllColorId(int id)
        {
            return _carDal.GetAllColorId(id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
            }
            else
            {
                Console.WriteLine("Kurallara Uygun Davranın");
            }
            
        }
    }
}
