using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Temperature");
            string temperature = Console.ReadLine();
            int intTemperature;
            int number;
            bool correctInput = int.TryParse(temperature, out number);

            if (correctInput)
            {
                intTemperature = number;
            } else
            {
                intTemperature = 0;
                Console.WriteLine("Value entered incorrect, disregard the below");
            }

            if (intTemperature < 0)
            {
                Console.WriteLine("It's freezing!");
            }
            else if(intTemperature < 10)
            {
                Console.WriteLine("Make sure to wear a Coat!");
            }
            else if(intTemperature < 20) {
                Console.WriteLine("It's a tad nippy out, wear something cosey.");
            }
            else if (intTemperature < 30)
            {
                Console.WriteLine("It's getting hot out there, wear something light.");
            }
            else if (intTemperature < 40)
            {
                Console.WriteLine("It's a fuckin heat wave, stay inside and put on the AC");
            } else
            {
                Console.WriteLine("Caution. Extreme Temperatures. Pray to God or die.");
            }

            Console.Read();
        }
    }
}
