using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Jagged Array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 4, 1, 6 };
            jaggedArray[1] = new int[] { 2, 3, 4};
            jaggedArray[2] = new int[] { 2, 3};

            // Declare Jagged Array - Alternative Method
            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 4, 1},
                new int[] {1, 2, 3}
            };

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Challenge Time!");
            Console.WriteLine("Create a Jagged Array which contains 3 friends, in which two of their family members are stored");
            Console.WriteLine("Family member are to be introduced to each other");
            Console.WriteLine();

            string[][] friendFamily = new string[][]
            {
                new string[] {"Giovanni", "Pauline"},
                new string[] {"Marika", "John"},
                new string[] {"Edwin", "Rita"}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendFamily[0][0], friendFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendFamily[2][1], friendFamily[1][1]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendFamily[0][1], friendFamily[2][0]);

            Console.Read();
        }
    }
}
