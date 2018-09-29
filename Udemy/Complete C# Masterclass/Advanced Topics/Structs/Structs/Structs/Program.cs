using System;

namespace Structs
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void DisplayAll()
        {
            Console.WriteLine("{0}:", name);
            Console.WriteLine(" - Developed by {0}", developer);
            Console.WriteLine(" - Rated {0}", rating);
            Console.WriteLine(" - Released on {0}", releaseDate);

        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.DisplayAll();

            Console.Read();

        }
    }
}
