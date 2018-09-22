using System;
using System.IO;

namespace ReadFromTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading text

            // method 1
            string text = System.IO.File.ReadAllText(@"D:\Git\Learning\Udemy\Complete C# Masterclass\OOP\Polymorphism\ReadFromTextFile\textFile.txt");
            Console.WriteLine("Text file contains the following text:");
            Console.WriteLine(text);
            Console.WriteLine();

            // method 2
            string[] lines = System.IO.File.ReadAllLines(@"D:\Git\Learning\Udemy\Complete C# Masterclass\OOP\Polymorphism\ReadFromTextFile\textFile.txt");
            Console.WriteLine("Contents of textFile.txt is: ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t {0}", line);
            }

            // Writing text

            // method 1
            string[] writeLines = { "Naruto - 7th Hokage", "Big Boss - Legendary Soldier *"};
            File.WriteAllLines(@"D:\Git\Learning\Udemy\Complete C# Masterclass\OOP\Polymorphism\ReadFromTextFile\textFile2.txt", writeLines);

            // method 2
            Console.WriteLine("Specify file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Input:");
            string input = Console.ReadLine();

            File.WriteAllText(@"D:\Git\Learning\Udemy\Complete C# Masterclass\OOP\Polymorphism\ReadFromTextFile\" + fileName + ".txt", input);

            // method 3
            using (StreamWriter file = new StreamWriter(@"D:\Git\Learning\Udemy\Complete C# Masterclass\OOP\Polymorphism\ReadFromTextFile\myText.txt", true))
            {
                foreach(string line in writeLines)
                {
                    if (line.Contains("*"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            Console.Read();

        }
    }
}
