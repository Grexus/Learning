using System;

namespace TryAndCatchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            string val1 = Console.ReadLine();
            int intVal1 = Int32.Parse(val1);

            Console.WriteLine("Enter second value");
            string val2 = Console.ReadLine();
            int intVal2 = Int32.Parse(val2);

            try
            {
                Divide(intVal1, intVal2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by 0 doofus. That would be infinity!");
            }

            Console.Read();
        }

        public static void Divide(int val1, int val2)
        {
            int answer = val1 / val2;
            Console.WriteLine("The answer is " + answer);
        }
    }
}
