using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesBasics
{

    // this class is a blueprint for a datatype
    class Human
    {
        //number variable
        private string firstname;
        private string lastname;
        private string eyeColor;
        private int age;

        // default constructor
        public Human() { }

        // parameterised constructor
        public Human(string firstname)
        {
            this.firstname = firstname;
        }

        // parameterised constructor
        public Human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        // parameterised constructor
        public Human(string firstname, string lastname, string eyeColor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
        }

        // parameterised constructor
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void Introduction()
        {
            if (lastname == null && eyeColor == null && age == 0)
            {
                Console.WriteLine("Hi, my name is " + firstname + ".");
            }
            else if (eyeColor == null && age == 0)
            {
                Console.WriteLine("Hi, my name is " + firstname + " " + lastname + ".");
            }
            else if (age == 0)
            {
                Console.WriteLine("Hi, my name is " + firstname + " " + lastname + ".");
                Console.WriteLine("I have " + eyeColor + " eyes.");
            } else if (age != 0)
            {
                if (age == 1) { 

                    Console.WriteLine("Hi, my name is " + firstname + " " + lastname + ".");
                    Console.WriteLine("I have " + eyeColor + " eyes and I am " + age + " year old.");
                }
                else
                {
                Console.WriteLine("Hi, my name is " + firstname + " " + lastname + ".");
                Console.WriteLine("I have " + eyeColor + " eyes and I am " + age + " years old.");
                }
            }            
            Console.WriteLine();
        }
    }
}
