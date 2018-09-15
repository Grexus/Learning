using System;
using System.Collections.Generic;
using System.Text;

namespace Members
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // member - public field
        public int age;

        // member - property
        public string JobTitle {
            get => jobTitle;
            set => jobTitle = value;
        }

        // member - method
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharePrivateInfo();
            } else
            {
                Console.Write("Hi, my name is {0}, I work as a {1}, and I am {2} years old", memberName, jobTitle, age);
            }
        }

        // member - method
        private void SharePrivateInfo()
        {
            Console.WriteLine("My salary is {0}.", salary);
        }

        // member - constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Full Stack Developer";
            Console.WriteLine("Object Creator");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}
