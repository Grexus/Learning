using System;

namespace ReturnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 22));
            Console.WriteLine(Add(40, 22));
            Console.WriteLine(Multiply(3, 10));
            Console.WriteLine(Divide(9, 4));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
