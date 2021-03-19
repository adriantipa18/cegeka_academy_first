using System;
using System.Collections.Generic;

namespace first_homework
{
    class Program
    {
        static List<Car> manufacteredCars = new List<Car>();
        static List<Package> predefinedPackages = new List<Package>();

        static int getNumberOfCars()
        {
            return manufacteredCars.Count;
        }

        static void printCars()
        {
            foreach (Car car in manufacteredCars)
            {
                Console.WriteLine('\n');
                Console.WriteLine(car.getInfo());
            }
        }


        static void getCar(string model)
        {
            foreach ( Car car in manufacteredCars)
            {
                if (model.Equals(car.getModel()))
                {
                    Console.WriteLine('\n');
                    Console.WriteLine(car.getInfo());
                    break;
                }
            }
        }

        static void menu()
        {

            Console.WriteLine("Welcome!");
            Console.WriteLine("You can create a car (command : createcar ), see number of cars ( command: carcount ) ");
            Console.WriteLine("list details of a certain model (getcar) or list all the cars manufactered ( command : getallcars )!");
            Console.Write("Choose a comand:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("create"))
                {
                    string tempCarBrand, tempCarModel;
                    Package tempPackage = new Package();
                    Console.Write("Name the brand:");
                    tempCarBrand = Console.ReadLine();
                    Console.Write("Name the model:");
                    tempCarModel = Console.ReadLine();
                    tempPackage.createCustom();

                    Car tempCar = new Car(tempCarBrand, tempCarModel, tempPackage);
                    manufacteredCars.Add(tempCar);
                }
                else
                if (input.ToLower().Equals("carcount"))
                {
                    Console.Write("Total numbers of cars manufactered so far: ");
                    Console.WriteLine(getNumberOfCars().ToString());
                }
                else
                    if (input.ToLower().Equals("getallcars"))
                {
                    printCars();
                }
                else
                if(input.ToLower().Equals("getcar"))
                {
                    string tempModel;
                    tempModel = Console.ReadLine();
                    getCar(tempModel);
                }else
                if (input.Equals("exit"))
                {
                    break;
                }
                Console.Write("Choose a comand:");
            }
        }
        static void Main(string[] args)
        {
            Package premium = new Package("Premium", 2.2, 160, "Automatic", true, true, true);
            Package plus = new Package("Plus", 2.2, 160, "Automatic", false, true, true);
            Package basic  = new Package("Basic", 2.2, 160, "Automatic", false, true, false);
            Package modest = new Package("Normal", 2.2, 160, "Automatic", false, true, false);


            Car car1 = new Car("Tesla", "ModelX", premium);
            Car car2 = new Car("Dacia", "Duster", basic);
            Car car3 = new Car("Honda", "Civic", plus);

            manufacteredCars.Add(car1);
            manufacteredCars.Add(car2);
            manufacteredCars.Add(car3);

            menu();
        }
    }
}
