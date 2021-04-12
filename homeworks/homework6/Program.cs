using System;
using ConsoleApp2.Database;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ConsoleApp2.Interfaces;
using homework6.Models;

namespace ConsoleApp2
{
    class Program
    {
        private static CarDealershipContext context;

        public Program()
        {
            context = new CarDealershipContext();
        }

        static void Main(string[] args)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();
            

            IRepository<Car> studentRepository = new EntityFrameworkRepository<Car>();
            
            studentRepository.Insert(
                new Car
                {
                    Brand = "Tesla",
                    Model = "ModelX",
                    Engine = 2.0,
                    TypeOfCar = "Electric",
                    HorsePower = 600,
                    HasElectricWindows = true,
                    HasNavigation = true
                });

            AddCar();
            ReadCar();
            ChangeCar();
            DeleteCar();

            context.Dispose();
        }

        private static void AddCar()
        {
            var context = new CarDealershipContext();
            try
            {

                var car = new Car
                {
                    Brand = "Tesla",
                    Model = "ModelX",
                    Engine = 2.0,
                    TypeOfCar = "Electric",
                    HorsePower = 600,
                    HasElectricWindows = true,
                    HasNavigation = true
                };

                context.CarContext.Add(car);
                context.SaveChanges();

            }
            finally
            {
                context.Dispose();
            }
        }

        private static void ReadCar()
        {
            using (var db = new CarDealershipContext())
            {

                var query = from b in db.CarContext orderby b.Model select b;
                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Brand + " " + item.Model);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        private static void ChangeCar()
        {

            using var context = new CarDealershipContext();

            var car = (from d in context.CarContext
                       where d.Brand == "Tesla"
                       select d).Single();
            car.Model = "ModelS";
            context.SaveChanges();
        }

        private static void DeleteCar()
        {

            using (var context = new CarDealershipContext())
            {
                var student = (from d in context.CarContext where d.Model == "ModelX" select d).Single();
                context.CarContext.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
