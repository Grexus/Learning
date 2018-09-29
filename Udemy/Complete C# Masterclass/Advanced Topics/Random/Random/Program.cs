using System;

namespace RandomMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Example
            Random dice = new Random();
            int diceValue;

            for (int i = 0; i < 10; i++)
            {
                diceValue = dice.Next(1, 7);
                Console.WriteLine(diceValue);
            }
            */

            // Yes, No, Maybe Program
            Random randomValue = new Random();
            int answerValue;
            string answer;

            do
            {
                Console.WriteLine("Ask a 'Yes' or 'No' question.");
                Console.ReadLine();

                answerValue = randomValue.Next(1, 4);


                if (answerValue == 1)
                {
                    Console.WriteLine("Yes");
                }
                else if (answerValue == 2)
                {
                    Console.WriteLine("No");
                }
                else if (answerValue == 3)
                {
                    Console.WriteLine("Maybe");
                }
                else { Console.WriteLine("DAFUK!?"); }

                Console.WriteLine();
                
            } while (true);
            




            Console.Read();
        }
    }
}
