using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllColorId(int id);
        List<Car> GetAllBrandId(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
