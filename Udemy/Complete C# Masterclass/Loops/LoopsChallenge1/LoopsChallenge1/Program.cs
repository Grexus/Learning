using System;

namespace LoopsChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int scores = 0;
            int score = 0;
            int numberOfStudents = 0;
            double average;

            Console.WriteLine("Enter student scores.");
            Console.WriteLine("Enter the value '-1' to calculate average of scores.");

            while (score != -1)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out score))
                {
                    if (score >= 0 && score <= 20)
                    {
                        scores += score;
                        numberOfStudents++;
                    }
                    else if (score > 20 || score < -1)
                    {
                        Console.WriteLine("Score must be between 0 and 20.");
                    }
                    else if (score == -1)
                    {
                        Console.WriteLine("Calculating average score ...");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter only integers");
                }
            }

            average = (double)scores / (double)numberOfStudents;

            Console.WriteLine("The average score is: " + average);
            Console.Read();
        }
    }
}
