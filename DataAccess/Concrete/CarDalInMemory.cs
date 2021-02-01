using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapProject.DataAccess.Concrete
{
    class CarDalInMemory : ICarDal
    {
        List<Car> _cars;

        public CarDalInMemory()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 6, DailyPrice = 350000, Description = "Sokda Octavia Energy Blue", ModelYear = "2020"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 1500000, Description = "Audi A8 Black", ModelYear = "2020"},
                new Car{Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 1000000, Description = "BMW 318i White", ModelYear = "2020"},
                new Car{Id = 4, BrandId = 4, ColorId = 2, DailyPrice = 350000, Description = "Renault Megane Grey", ModelYear = "2020"},
                new Car{Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 2000000, Description = "Wolksvagen Passat Dark Blue", ModelYear = "2020"},
                new Car{Id = 6, BrandId = 6, ColorId = 4, DailyPrice = 1700000, Description = "Mercedes AMG-180 Green", ModelYear = "2020"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int Id)
        {
            Car deletingCar = _cars.SingleOrDefault(c => c.Id == Id);
            _cars.Remove(deletingCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            Car updatingCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatingCar.DailyPrice = car.DailyPrice;
            updatingCar.ColorId = car.ColorId;
            updatingCar.Description = car.Description;
        }
    }
}
