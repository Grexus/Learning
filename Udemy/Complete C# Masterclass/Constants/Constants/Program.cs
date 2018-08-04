using System;

namespace Constants
{

    // Constants are immutabe values which are known at compile time and do not change for the lifespan of the program

    class Program
    {

        // Constants as fields
        const int weeks = 52, months = 12;
        const string birthday = "30th November 1994";

        static void Main(string[] args)
        {
            Console.WriteLine(birthday);
            Console.Read();
        }
    }
}
