using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Add());
            Console.Read();
        }

        public static int Add()
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter first value");
            string val1 = Console.ReadLine();
            int intVal1 = Int32.Parse(val1);

            Console.WriteLine("Enter second value");
            string val2 = Console.ReadLine();
            int intVal2 = Int32.Parse(val2);

            int sum = intVal1 + intVal2;

            return(sum);
        }
    }
}
