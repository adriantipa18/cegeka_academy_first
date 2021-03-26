using homework4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace homework4.Services
{
    public class GarageService
    {
        internal void AddCar(List<Car> cars, Car car)
        {
            foreach (Car tempCar in cars)
            {
                if (car.Id == tempCar.Id)
                {
                    throw new ArgumentException("Id already exists!");
                }
            }
            cars.Add(car);
        }

        internal bool DeleteCar(List<Car> cars, int id)
        {
            if (cars.Count() != 0)
            {
                int index = -1;
                foreach (Car car in cars)
                {
                    if (id == car.Id)
                    {
                        index = cars.IndexOf(car);
                        break;
                    }
                }
                if (index != -1)
                {
                    cars.RemoveAt(index);
                }
            }
            return false;
        }


        private int GetIndexOf(List<Car> cars, Car car)
        {
            foreach(Car tempCar in cars)
            {
                if(car.Id == tempCar.Id)
                {
                    return cars.IndexOf(tempCar);
                }
            }
            return -1;
        }

        internal void UpdateCar(List<Car> cars, Car car)
        {
            int indexOfCarToUpdate = GetIndexOf(cars, car);
            if ( indexOfCarToUpdate != -1)
            {
                try
                {
                    if (car.Brand != null)
                    {
                        cars[indexOfCarToUpdate].Brand = car.Brand;
                    }
                    if (car.Model != null)
                    {
                        cars[indexOfCarToUpdate].Model = car.Model;
                    }
                    if (car.HorsePower != null)
                    {
                        cars[indexOfCarToUpdate].HorsePower = car.HorsePower;
                    }
                    if (car.Engine != null)
                    {
                        cars[indexOfCarToUpdate].Engine = car.Engine;
                    }
                    if (car.type != null)
                    {
                        cars[indexOfCarToUpdate].type = car.type;
                    }
                }
                catch (ArgumentException e)
                {
                    throw e;
                }
            }
            else
            {
                    throw new ArgumentException("Car does not exists!");
            }

        }
       
    }
}
