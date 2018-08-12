using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter);
                if(counter == 3)
                {
                    Console.WriteLine("We're breaking the loop at 3");
                    break; // or continue
                }
            }
            Console.Read();
        }
    }
}
