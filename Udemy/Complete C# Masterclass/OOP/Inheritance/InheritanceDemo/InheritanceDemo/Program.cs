using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post();
            Post post2 = new Post("Thanks for the birthday wishes", true, "Gr3xu5");
            Post post3 = new Post("My love", true, "HopelessRomantik");
            ImagePost imagePost1 = new ImagePost("Beautiful Barcelona", "Wanderer", "/images/barcelona/sagrada-familia.jpg", true);
            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());
            Console.WriteLine(post3.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.ReadLine();
        }
    }
}
