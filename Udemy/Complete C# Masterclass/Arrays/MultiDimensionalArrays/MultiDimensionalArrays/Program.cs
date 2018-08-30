using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2D Array         
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine("Central value of 2D Array is {0}", array2D[1,1]);

            // declare 3D Array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up?"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Bites the dust"}
                },
            };

            Console.WriteLine("{0}, {1}", array3D[0, 2, 0], array3D[0, 2, 1]);

            // declare 2D Array with 3 rows containing 2 items each
            string[,] array2DString = new string[3, 2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five", "six"},
            };

            // Challenge
            Console.WriteLine("Challenge Time!");
            Console.WriteLine("Change the string 'four' to 'chicken'.");
            Console.WriteLine();

            array2DString[1, 1] = "Chicken";

            Console.WriteLine("The answer is {0}", array2DString[1,1]);

            // Challenge Parameters
            if(array2DString[1,1] == "Chicken")
            {
                Console.WriteLine("DING DING DING!");
                Console.WriteLine();
            } else
            {
                Console.WriteLine("Meh");
                Console.WriteLine();
            }

            // Find out how many dimensions an array has
            int dimensions = array2DString.Rank;

            Console.WriteLine("The number of dimensions in array2DString is: {0}", dimensions);

            Console.Read();
        }
    }
}
