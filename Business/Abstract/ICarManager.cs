using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    interface ICarManager
    {
        List<Car> GetAllCars();
        Car GetCarById(int carId);
        void AddCar(Car car);
        void DeleteCar(int Id);
        void UpdateCar(Car car);
    }
}
