using System;

namespace ClassesBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human
            Human matthew = new Human("Matthew", "Grech", "Brown", 23);
            Human janice = new Human("Janice", "Grech", "Brown", 1);

            matthew.Introduction();
            janice.Introduction();

            Console.Read();
        }
    }
}
