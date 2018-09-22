using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi("TT", 184, "Black"),
                new BMW("Z4", 200, "Silver")
            };

            foreach(var car in cars)
            {
                car.Repair(); // override approach
            }

            M3 myM3 = new M3("M3", 160, "Red");
            myM3.SetCarIDInfo(147, "Matthew");
            myM3.GetCarIDInfo();
            myM3.Repair();

            Console.Read();
        }
    }
}
