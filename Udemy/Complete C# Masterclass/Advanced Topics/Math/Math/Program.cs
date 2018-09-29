using System;


namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Classes");
            Console.WriteLine("Ceiling of 15.3 is {0}", Math.Ceiling(15.3));
            Console.WriteLine("Flooring of 16.4 is {0}", Math.Floor(17.4));

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine("Lower of {0} and {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher of {0} and {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3,5));
            Console.WriteLine("Pi is {0}", Math.PI);
            Console.WriteLine("Square Root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Cos of 1 is {0}", Math.Cos(1));

            Console.ReadLine();
        }
    }
}
