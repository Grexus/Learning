using System;

namespace Enums
{

    enum Day
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    };

    class Program
    {
        static void Main(string[] args)
        {
            Day fri = Day.Friday;

            Console.WriteLine(Day.Monday);
            Console.WriteLine((int)Day.Monday);

            Console.WriteLine((int)Months.Feb);

            
        }
    }
}
