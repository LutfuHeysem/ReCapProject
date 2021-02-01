using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    interface ICarDal
    {
        List<Car> GetAll();
        Car GetById(int carId);
        void Add(Car car);
        void Delete(int Id);
        void Update(Car car);
    }
}
