using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<CarDetailsDto> GetCarrDetails();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
