using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring an Array List (undefined amount of objects)
            ArrayList myArrayList = new ArrayList();

            // declaring an Array List (defined amount of objects)
            ArrayList myArrayList2 = new ArrayList(10);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(12.2);
            myArrayList.Add(8);
            myArrayList.Add(30);
            myArrayList.Add("Matthew");
            myArrayList.Add(21);

            // delete element with specific value (first instance)
            myArrayList.Remove(21);

            // delete element at a specific position
            myArrayList.RemoveAt(1);

            // count
            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object item in myArrayList)
            {
                if (item is int)
                {
                    sum += Convert.ToDouble(item);
                } else if(item is double)
                {
                    sum += (double)item;
                } else if (item is string){
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine(sum);

            Console.Read();
        }
    }
}
