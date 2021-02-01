using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    class CarManager : ICarManager
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void AddCar(Car car)
        {
            _carDal.Add(car);
        }

        public void DeleteCar(int Id)
        {
            _carDal.Delete(Id);
        }

        public List<Car> GetAllCars()
        {
           return _carDal.GetAll();
        }

        public Car GetCarById(int carId)
        {
           return _carDal.GetById(carId);
        }

        public void UpdateCar(Car car)
        {
            _carDal.Update(car);
        }
    }
}
