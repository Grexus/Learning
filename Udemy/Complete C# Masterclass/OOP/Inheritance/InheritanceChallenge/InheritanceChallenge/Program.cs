using System;

namespace InheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("Matthew", "Grech", 50000, "Smart ForTwo");
            Employee employee1 = new Employee("John", "Doe", 25000);
            Trainee trainee1 = new Trainee("Jane", "Brown", 16000, 20, 20);

            employee1.Work();
            employee1.Pause();
            Console.WriteLine();
            boss.Work();
            boss.Lead();
            boss.Pause();
            Console.WriteLine();
            trainee1.Learn();
            trainee1.Work();

            Console.Read();
        }
    }
}
