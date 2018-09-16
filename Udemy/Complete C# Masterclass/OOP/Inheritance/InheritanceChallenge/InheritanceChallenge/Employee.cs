using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            FirstName = "Default First Name";
            LastName = "Default Last Name";
            Salary = 50000;
        }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public void Work() {
            Console.WriteLine("{0} {1} is working", FirstName, LastName);
        }

        public void Pause() {
            Console.WriteLine("{0} {1} is taking a break", FirstName, LastName);
        }

    }
}
