using System;

namespace NestedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in.");
            }

            if (isRegistered)
            {
                if (userName == "")
                {
                    Console.WriteLine("Hi there!");
                }
                else if(userName != ""){
                    Console.WriteLine("Hi there, " + userName);

                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Weird name dude.");
                    }
                }
            }

            Console.Read();
        }
    }
}
