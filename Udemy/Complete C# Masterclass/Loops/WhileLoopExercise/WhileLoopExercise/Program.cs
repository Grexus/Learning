using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int numberOfStudents;
            string input;

            Console.WriteLine("How many students should you have with you?");
            numberOfStudents = Int32.Parse(Console.ReadLine());

            while (counter < numberOfStudents)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    counter++;
                    Console.WriteLine("Student Check-in number: " + counter);
                } else if (input == "count")
                {
                    Console.WriteLine("Final Student Check-in number: " + counter);
                    if(counter < numberOfStudents)
                    {
                        Console.WriteLine(numberOfStudents - counter + " students missing!");
                    }
                }
            }
            Console.WriteLine("All aboard!");
            Console.Read();
        }
    }
}
