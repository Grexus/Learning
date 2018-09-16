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
            VideoPost videoPost1 = new VideoPost("Sick stuntzzZz", "AdrenalineJunkie221", "/videos/stunts/skateboard-stunts.mp4", 24, true);
            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());
            Console.WriteLine(post3.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Press any key to stop playing video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
        }
    }
}
