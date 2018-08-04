using System;

namespace MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Janice";
            string friend2 = "Karl";
            string friend3 = "Ismael";

            GreetFriend1(friend1);
            GreetFriend1(friend2);
            GreetFriend1(friend3);

            GreetFriend2(friend1, friend2, friend3);

            Console.Read();
        }

        public static void GreetFriend1(string friendName)
        {
            Console.WriteLine("Hello there " + friendName);
        }

        public static void GreetFriend2(string friendName1, string friendName2, string friendName3)
        {
            Console.WriteLine("Hello there " + friendName1);
            Console.WriteLine("Hello there " + friendName2);
            Console.WriteLine("Hello there " + friendName3);
        }
    }
}
