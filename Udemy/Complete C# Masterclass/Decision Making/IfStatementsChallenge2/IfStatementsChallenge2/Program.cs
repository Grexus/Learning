using System;

namespace IfStatementsChallenge2
{
    class Program
    {

        static int score, highscore;
        static string player, highscorePlayer;

        static void Main(string[] args)
        {
            highscorePlayer = "Jonas";
            highscore = 729;

            Console.WriteLine("What is your score?");
            score = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is your name?");
            player = Console.ReadLine();

            CheckHighscore(score, player);

            Console.Read();
        }

        public static void CheckHighscore(int score, string player)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = player;
                Console.WriteLine("New highscore is " + highscore + "!");
                Console.WriteLine("Owner: " + highscorePlayer);
            } else
            {
                Console.WriteLine(player + " has failed to beat the highscore of " + highscore + " held by " + highscorePlayer + "!");
            }
        }
    }
}
