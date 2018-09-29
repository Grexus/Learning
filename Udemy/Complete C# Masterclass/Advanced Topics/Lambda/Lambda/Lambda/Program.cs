using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        // parameter => expression /  statement block
        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            Console.Read();
        }

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(TimesTen);
            Console.WriteLine(math(8));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            // method 1 - Delegates
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            // method 2 - LAMBDA
            List<int> oddNumbers = list.FindAll(i => i % 2 == 1);
            oddNumbers.ForEach(i => Console.WriteLine(i));

            math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(8));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5 }));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int a)
        {
            return a * a;
        }

        public static int TimesTen(int a)
        {
            return a * 10;
        }
    }
}
