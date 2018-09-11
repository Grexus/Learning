using System;

namespace ArrayParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = new int[] { 12, 22, 112, 5, 20 };
            double averageResult = GetAverage(studentGrades);

            foreach(int grade in studentGrades){
                Console.WriteLine(grade);
            }

            Console.WriteLine("Average mark is {0}", averageResult);
            Console.WriteLine();
            Console.WriteLine("Challenge");
            Console.WriteLine();

            int[] currentHappiness = new int[] { 8, 4, 7, 2, 9 };

            Console.WriteLine("Before happiness boost:");
            foreach (int happiness in currentHappiness)
            {
                Console.WriteLine(happiness);
            }

            // Apply Boost
            HappinessBoost(currentHappiness);
            Console.WriteLine("After happiness boost:");
            foreach(int happiness in currentHappiness)
            {
                Console.WriteLine(happiness);
            }
            Console.Read();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }

        static void HappinessBoost(int[] currentHappiness)
        {
            for(int i = 0; i < currentHappiness.Length; i++)
            {
                currentHappiness[i] = currentHappiness[i] + 2;
            }
        }
    }
}
