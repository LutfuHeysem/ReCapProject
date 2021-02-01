using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ReCapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDalInMemory());
            Console.WriteLine("----------List All Cars----------");
            List<Car> Cars = carManager.GetAllCars();
            foreach (var car in Cars)
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }
            Console.WriteLine("----------List All Cars----------");
            Console.WriteLine("");

            Console.WriteLine("----------Add New Car----------");
            Car newCar1 = new Car {Id = 7, BrandId = 1, Description = "Skoda Octavia Black", ColorId = 1, DailyPrice = 360000, ModelYear = "2020" };
            carManager.AddCar(newCar1);
            Car addedCar = carManager.GetCarById(newCar1.Id);
            Console.WriteLine(addedCar.Id + " " + addedCar.Description);
            Console.WriteLine("----------Add New Car----------");
            Console.WriteLine("");


            Console.WriteLine("----------Update Car----------");
            Car updatingCar = new Car {Id = 7, BrandId = 1, Description = "Skoda Octavia Grey", ColorId = 2, DailyPrice = 400000, ModelYear = "2021" };
            carManager.UpdateCar(updatingCar);
            Car updatedCar = carManager.GetCarById(updatingCar.Id);
            Console.WriteLine(updatedCar.Id + " " + updatedCar.Description);
            Console.WriteLine("----------Update Car----------");
            Console.WriteLine("");

            Console.WriteLine("----------Delete Car----------");
            carManager.DeleteCar(7);
            Cars = carManager.GetAllCars();
            foreach (var car in Cars)
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }
            Console.WriteLine("----------Delete Cars----------");
            Console.WriteLine("");

        }
    }
}
