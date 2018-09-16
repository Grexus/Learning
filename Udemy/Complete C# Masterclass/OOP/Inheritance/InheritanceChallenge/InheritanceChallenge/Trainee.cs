using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHours):base(firstName, lastName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn() {
            Console.WriteLine("{0} {1} has studied for {2}", FirstName, LastName, SchoolHours);
        }

        public new void Work()
        {
            Console.WriteLine("{0} {1} has worked {2} hours", FirstName, LastName, WorkingHours);
        }


    }
}
