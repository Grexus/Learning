using System;

namespace IfStatmentsChallenge
{
    class Program
    {

        static string username, password, passwordVerification, loginUser, loginPassword;
        static bool registerComplete;

        static void Main(string[] args)
        {

     
            Register();

            if (registerComplete)
            {
                Login();
            } else
            {
                Console.WriteLine("Please try again.");
            }
            

            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("What will be your User Name?");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
            Console.WriteLine("Verify Password");
            passwordVerification = Console.ReadLine();
            if (username != "" && password == passwordVerification)
            {
                registerComplete = true;
                Console.WriteLine("Account has been created successfully!");
                Console.WriteLine("--------------------------------------");
            }
            else if (password != passwordVerification)
            {
                Console.WriteLine("Passwords provided do not match.");
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }

        public static void Login()
        {
            Console.WriteLine("Login to your Account");
            Console.WriteLine("Username:");
            loginUser = Console.ReadLine();
            Console.WriteLine("Password:");
            loginPassword = Console.ReadLine();

            if (loginUser == username && loginPassword == password)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Incorrect login details.");
            }
        }
    }
}
