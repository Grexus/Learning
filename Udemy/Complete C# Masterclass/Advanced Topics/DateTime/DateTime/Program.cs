using System;

namespace DateAndTime
{
    class Program
    {
  
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1994, 11, 30);

            Console.WriteLine("My birthday is on {0}", dateTime);

            // Display Current Date
            Console.WriteLine(DateTime.Today);

            // Display Current Time According to PC
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Tomorrow will be {0}", DateTime.Today.AddDays(1));

            Console.WriteLine("Today is {0}", DateTime.Now.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(1990));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            int days2 = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days2);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            DateTime challengeNow = DateTime.Now;
            Console.WriteLine("{0} o'clock, {1} minutes, {2} seconds and {3} milliseconds", challengeNow.Hour, challengeNow.Minute, challengeNow.Second, challengeNow.Millisecond);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            } else
            {
                Console.WriteLine("Wrong Input");
            }

            Console.WriteLine("Input a birthday to calculate how many days you have lived!");
            Console.WriteLine("Day:");
            string inputDay = Console.ReadLine();
            Console.WriteLine("Month:");
            string inputMonth = Console.ReadLine();
            Console.WriteLine("Year:");
            string inputYear = Console.ReadLine();

            string inputFullBirthday = inputYear + "-" + inputMonth + "-" + inputDay;

            if(DateTime.TryParse(inputFullBirthday, out dateTime))
            {
                Console.WriteLine("{0}/{1}/{2}", inputDay, inputMonth, inputYear);
                TimeSpan daysLived = now.Subtract(dateTime);
                Console.WriteLine("{0} days have passed since you were born!", daysLived.Days);
            } else
            {
                Console.WriteLine("Invalid Input");
            }




            Console.Read();
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
