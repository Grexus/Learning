using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please use only numbers");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, number too long for int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty");
            }
            finally
            {
                Console.WriteLine("This is called no matter what");
            }

            Console.ReadKey();
        }
    }
}
