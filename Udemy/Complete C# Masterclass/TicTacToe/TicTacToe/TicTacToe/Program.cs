using System;

namespace TicTacToe
{
    class Program
    {


        static void Main(string[] args)
        {
            bool gamePlaying = true;
            bool nextPlayer = true;

            int rounds = 0;

            string playerTurn = null;
            string playerAction;
            string playerSymbol = null;
            string[] ticTacToeArray = {"1","2","3","4","5","6","7","8","9"};


            while (gamePlaying && rounds < 9)
            {
                Console.Clear();

                // Switch Player
                if (nextPlayer)
                {
                    SwitchPlayer(ref playerTurn, ref playerSymbol);
                }

                // Print TicTacToe Board
                PrintTicTacToeBoard(ticTacToeArray);

                // Game Instructions
                Console.WriteLine();
                Console.WriteLine("Player {0}'s turn", playerTurn);
                Console.WriteLine("Please enter a number where to place the '{0}'", playerSymbol);
                Console.WriteLine();

                // Error Message
                if (!nextPlayer)
                {
                    Console.WriteLine("Incorrect input, try again.");
                }

                // Player Action Input
                playerAction = Console.ReadLine();

                // Player Action
                if (int.TryParse(playerAction, out int playerActionInt) && playerActionInt > 0 && playerActionInt < 10) // removes wrong inputs
                {
                    if (int.TryParse(ticTacToeArray[playerActionInt - 1], out int parsedPlayerAction)) 
                    {
                        ticTacToeArray[playerActionInt - 1] = playerSymbol;
                        nextPlayer = true;
                    } else
                    {
                        nextPlayer = false;
                    }
                }
                else
                {
                    nextPlayer = false;
                }

                // Game Logic
                GameLogic(ref ticTacToeArray, ref gamePlaying, ref playerTurn);

                if (nextPlayer == true)
                {
                    rounds++;
                }
            }

            // Draw statement
            if(gamePlaying == true)
            {
                Console.WriteLine("It's a draw!");
            }


            Console.Read();
        }

        // Print TicTacToe Board
        static void PrintTicTacToeBoard(string[] ticTacToeArray)
        {
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", ticTacToeArray[0], ticTacToeArray[1], ticTacToeArray[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", ticTacToeArray[3], ticTacToeArray[4], ticTacToeArray[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", ticTacToeArray[6], ticTacToeArray[7], ticTacToeArray[8]);
            Console.WriteLine("     |     |    ");
        }

        // Switch Player
        static void SwitchPlayer(ref string playerTurn, ref string playerSymbol) {
            if (playerTurn != "1")
            {
                playerTurn = "1";
                playerSymbol = "x";
            }
            else
            {
                playerTurn = "2";
                playerSymbol = "o";
            }
        }

        // Game Logic
        static void GameLogic(ref string[] ticTacToeArray, ref bool gamePlaying, ref string playerTurn)
        {
            // Horizontal
            if (ticTacToeArray[0] == ticTacToeArray[1] && ticTacToeArray[0] == ticTacToeArray[2])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            else if (ticTacToeArray[3] == ticTacToeArray[4] && ticTacToeArray[3] == ticTacToeArray[5])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            else if (ticTacToeArray[6] == ticTacToeArray[7] && ticTacToeArray[6] == ticTacToeArray[8])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            // Vertical
            else if (ticTacToeArray[0] == ticTacToeArray[3] && ticTacToeArray[0] == ticTacToeArray[6])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            else if (ticTacToeArray[1] == ticTacToeArray[4] && ticTacToeArray[1] == ticTacToeArray[7])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            else if (ticTacToeArray[2] == ticTacToeArray[5] && ticTacToeArray[2] == ticTacToeArray[8])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            // Diagonal
            else if (ticTacToeArray[0] == ticTacToeArray[4] && ticTacToeArray[0] == ticTacToeArray[8])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
            else if (ticTacToeArray[2] == ticTacToeArray[4] && ticTacToeArray[2] == ticTacToeArray[6])
            {
                Console.WriteLine("Game Over! Player {0} won the game!", playerTurn);
                gamePlaying = false;
            }
        }
    }
}
