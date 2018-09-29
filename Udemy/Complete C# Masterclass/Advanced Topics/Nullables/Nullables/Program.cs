using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolean = new bool?();

            Console.WriteLine("Nullable values: {0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, boolean);
            

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is female");
            } else
            {
                Console.WriteLine("No gender chosen");
            }


            // Null coalescing operator ??
            // if is null set a default value
            double? num5 = 13.1;
            double? num6 = null;
            double num7;

            num7 = num6 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);

            num7 = num5 ?? 8.53;
            Console.WriteLine("Value of num7 is {0}", num7);


            Console.Read();
        }
    }
}
