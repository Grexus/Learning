using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(5, 5, 5);
            box1.DisplayInfo();

            Console.Read();
        }
    }
}
