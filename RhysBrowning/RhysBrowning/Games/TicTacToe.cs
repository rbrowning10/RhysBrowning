using System;
using System.Threading;

namespace RhysBrowning.Games
{
    class TicTacToe

    {
        static char[] moves = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;

        // match states 
        static int matchState = 0;

        public static void TicTacToeMain(string[] args)

        {
            do
            {
                Console.Clear();

                Console.WriteLine("Player 1: X");

                Console.WriteLine("\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2");
                }
                else
                {
                    Console.WriteLine("Player 1");
                }

                Console.WriteLine("\n");

                GenerateBoard();

                choice = int.Parse(Console.ReadLine());

                // checking that position is not taken
                if (moves[choice] != 'X' && moves[choice] != 'O')
                {
                    //determines if player 1 or 2 is going
                    if (player % 2 == 0)
                    {
                        moves[choice] = 'O';
                    }
                    else
                    {
                        moves[choice] = 'X';
                    }
                    player++;
                }
                else
                {
                    //selected board position has been used before
                    Console.WriteLine("Position {0} is already marked with {1}", choice, moves[choice]);
                }

                // check status of game 
                matchState = CheckMatchState();

            }
            // while matchstate is not drawn or won
            while (matchState != 1 && matchState != -1);

            Console.Clear();
            GenerateBoard();

            //match has been won
            if (matchState == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            //match drawn
            else
            {
                Console.WriteLine("Draw");
            }

            Console.ReadLine();
        }

        // Generates the board and moves taken
        private static void GenerateBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", moves[1], moves[2], moves[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", moves[4], moves[5], moves[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", moves[7], moves[8], moves[9]);
            Console.WriteLine("     |     |      ");
        }

        private static int HorizontalWinCheck()
        {
            if (moves[1] == moves[2] && moves[2] == moves[3])
            {
                return 1;
            }
            else if (moves[4] == moves[5] && moves[5] == moves[6])
            {
                return 1;
            }
            else if (moves[6] == moves[7] && moves[7] == moves[8])
            {
                return 1;
            }

            return 0;
        }

        private static int VerticalWinCheck()
        {
            if (moves[1] == moves[4] && moves[4] == moves[7])
            {
                return 1;
            }
            else if (moves[2] == moves[5] && moves[5] == moves[8])
            {
                return 1;
            }
            else if (moves[3] == moves[6] && moves[6] == moves[9])
            {
                return 1;
            }

            return 0;
        }

        private static int DiagonalWinCheck()
        {
            if (moves[1] == moves[5] && moves[5] == moves[9])
            {
                return 1;
            }

            else if (moves[3] == moves[5] && moves[5] == moves[7])
            {
                return 1;
            }

            return 0;
        }

        private static int DrawCheck()
        {
            if (moves[1] != '1' && moves[2] != '2' && moves[3] != '3' && moves[4] != '4' && moves[5] != '5' && moves[6] != '6' && moves[7] != '7' && moves[8] != '8' && moves[9] != '9')
            {
                return -1;
            }

            return 0;
        }

        //Checking match state 
        private static int CheckMatchState()
        {
            if (HorizontalWinCheck() == 1)
                return 1;

            if (VerticalWinCheck() == 1)
                return 1;

            if (DiagonalWinCheck() == 1)
                return 1;

            if (DrawCheck() == -1)
                return -1;

            return 0;
        }

    }
}
