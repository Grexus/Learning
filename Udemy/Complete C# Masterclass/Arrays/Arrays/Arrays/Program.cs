using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 16;
            grades[3] = 9;
            grades[4] = 12;


            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            // assign value to array grades at index 0
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 : {0}", grades[0]);


            int[] gradesOfMathStudentsA = { 20, 13, 22, 15, 9 };
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 22, 15, 9 };

            Console.WriteLine("Length of grades A is: {0}", gradesOfMathStudentsA.Length);
            Console.Read();
        }
    }
}
