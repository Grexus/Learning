using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            bool gamePlaying = true;
            bool nextPlayer = true;

            string playerTurn = null;
            string playerAction;
            string playerSymbol = null;
            string[] ticTacToeArray = {"1","2","3","4","5","6","7","8","9"};

            while (playAgain)
            {
                while (gamePlaying)
                {
                    Console.Clear();

                    if (nextPlayer)
                    {
                        // Switch Player
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

                    // Print TicTacToe Board
                    Console.WriteLine("{0} | {1} | {2}", ticTacToeArray[0], ticTacToeArray[1], ticTacToeArray[2]);
                    Console.WriteLine("{0} | {1} | {2}", ticTacToeArray[3], ticTacToeArray[4], ticTacToeArray[5]);
                    Console.WriteLine("{0} | {1} | {2}", ticTacToeArray[6], ticTacToeArray[7], ticTacToeArray[8]);
                    Console.WriteLine();
                    Console.WriteLine("Player {0}'s turn", playerTurn);
                    Console.WriteLine("Please enter a number where to place the '{0}'", playerSymbol);
                    playerAction = Console.ReadLine();


                    // Player Action
                    switch (playerAction)
                    {
                        case "1":
                            if (ticTacToeArray[0] == "1")
                            {
                                ticTacToeArray[0] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "2":
                            if (ticTacToeArray[1] == "2")
                            {
                                ticTacToeArray[1] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "3":
                            if (ticTacToeArray[2] == "3")
                            {
                                ticTacToeArray[2] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "4":
                            if (ticTacToeArray[3] == "4")
                            {
                                ticTacToeArray[3] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "5":
                            if (ticTacToeArray[4] == "5")
                            {
                                ticTacToeArray[4] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "6":
                            if (ticTacToeArray[5] == "6")
                            {
                                ticTacToeArray[5] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "7":
                            if (ticTacToeArray[6] == "7")
                            {
                                ticTacToeArray[6] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "8":
                            if (ticTacToeArray[7] == "8")
                            {
                                ticTacToeArray[7] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        case "9":
                            if (ticTacToeArray[8] == "9")
                            {
                                ticTacToeArray[8] = playerSymbol;
                                nextPlayer = true;
                            }
                            else
                            {
                                nextPlayer = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect input, try again.");
                            break;
                    }

                    // Game Logic
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
                    else if (ticTacToeArray[6] == ticTacToeArray[6] && ticTacToeArray[6] == ticTacToeArray[8])
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

            Console.Read();
        }
    }
}
