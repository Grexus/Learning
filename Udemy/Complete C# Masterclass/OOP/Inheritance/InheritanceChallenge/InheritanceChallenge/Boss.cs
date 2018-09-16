using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceChallenge
{
    class Boss:Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string firstName, string lastName, int salary, string companyCar):base(firstName, lastName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead() {
            Console.WriteLine("{0} {1} is leading the team", FirstName, LastName);
        }
    }
}
