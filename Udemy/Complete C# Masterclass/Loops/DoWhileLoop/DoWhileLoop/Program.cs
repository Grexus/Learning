using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int lengthOfText = 0;
            string idols = "";
            do { 
                Console.WriteLine("Enter the name of your idol.");
                string nameOfIdol = Console.ReadLine() + ", ";
                int currentLength = nameOfIdol.Length;
                lengthOfText += currentLength;
                idols += nameOfIdol;
            } while (lengthOfText < 10);
            Console.WriteLine("Thank you for your input. Named idols are: " + idols);
            Console.Read();
        }
    }
}
