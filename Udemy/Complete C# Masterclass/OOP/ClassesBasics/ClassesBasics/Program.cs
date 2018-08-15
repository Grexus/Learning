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
            Human janice = new Human("Janice", "Grech", "Brown");
            Human jane = new Human("Jane", "Doe");
            Human john = new Human("John");

            matthew.Introduction();
            janice.Introduction();
            jane.Introduction();
            john.Introduction();

            Console.Read();
        }
    }
}
