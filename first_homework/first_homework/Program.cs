using System;

namespace first_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Package premium = new Package("Premium", 2.2, 160, "Automatic", true, true, true);
            Package plus = new Package("Plus", 2.2, 160, "Automatic", false, true, true);
            Package basic  = new Package("Basic", 2.2, 160, "Automatic", false, true, false);
            Package modest = new Package("Normal", 2.2, 160, "Automatic", false, true, false);
            //Console.WriteLine(premium.getInfo());


            Car car = new Car("Tesla", "ModelX", premium);
            
            Console.WriteLine(car.getInfo());
        }
    }
}
