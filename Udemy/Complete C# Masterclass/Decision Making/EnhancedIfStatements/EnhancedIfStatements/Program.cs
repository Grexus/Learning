using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // condition ? first_expression : second_expression;
            // condition has to be either true or false
            // the conditional operator is right - associative

            int temperature = -5;
            string waterState;

            // enhanced if statement
            waterState = temperature < 0 ? "Solid" : temperature > 100 ? "Gas" : "Liquid";


            Console.WriteLine("Water is a " + waterState);
            Console.Read();
        }
    }
}
