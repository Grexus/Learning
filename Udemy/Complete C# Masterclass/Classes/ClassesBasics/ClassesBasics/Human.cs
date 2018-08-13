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

        // constructor
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
            Console.WriteLine("Hi, my name is " + firstname + " " + lastname + ".");
            if (age == 1)
            {
                Console.WriteLine("I have " + eyeColor + " eyes and I am " + age + " year old.");
            } else
            {
                Console.WriteLine("I have " + eyeColor + " eyes and I am " + age + " years old.");
            }
            Console.WriteLine();
        }
    }
}
