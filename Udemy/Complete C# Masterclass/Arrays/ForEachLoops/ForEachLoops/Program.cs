using System;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
            }

            int counter = 0;
            foreach(int j in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, j);
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine("Challenge Time!");
            Console.WriteLine();

            string[] friends = { "Janice", "Karl", "Sergio", "Ismael", "Macram"};
            
            foreach(string friend in friends)
            {
                Console.WriteLine("Greetings, {0}", friend);
            }

            Console.WriteLine("Challenge SUCCESS!");

            Console.Read();
        }
    }
}
