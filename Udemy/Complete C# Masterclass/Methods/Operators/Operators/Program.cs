using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 = {0}", num3);
            

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num = {0}", num);
            Console.WriteLine("num = {0}", num++); // post increment
            Console.WriteLine("num = {0}", ++num); // pre increment

            // decrement operators
            num--;
            Console.WriteLine("num = {0}", num);
            Console.WriteLine("num = {0}", num--); // post decrement
            Console.WriteLine("num = {0}", --num); // pre decrement

            int result;
            // add operator
            result = num1 + num2;
            Console.WriteLine("The result of num1 + num2 is {0}", result);

            // subtract operator
            result = num1 - num2;
            Console.WriteLine("The result of num1 - num2 is {0}", result);

            // multiply operator
            result = num1 * num2;
            Console.WriteLine("The result of num1 * num2 is {0}", result);

            // divide operator
            result = num1 / num2;
            Console.WriteLine("The result of num1 / num2 is {0}", result);

            // modulo operator
            result = num1 % num2;
            Console.WriteLine("The result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower = num1 < num2;
            Console.WriteLine("num1 is less than num2: {0}", isLower);

            bool isHigher = num1 > num2;
            Console.WriteLine("num1 is more than num2: {0}", isHigher);

            // equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("num1 is equal to num2: {0}", isEqual);

            bool isNotEqual = num1 != num2;
            Console.WriteLine("num1 is not equal to num2: {0}", isNotEqual);

            // logical operators

            // AND
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny: {0}", isLowerAndSunny);


            // OR
            bool isLowerOrSunny;
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny: {0}", isLowerOrSunny);

            Console.Read();
        }
    }
}
