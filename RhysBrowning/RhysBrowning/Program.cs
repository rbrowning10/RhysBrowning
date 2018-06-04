using RhysBrowning.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RhysBrowning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Console Arcade ---");
            Console.WriteLine("Pick a game!");
            Console.WriteLine("\n1. Tic Tac Toe");
            Console.WriteLine("2. Darts Throw Counter");
            Console.WriteLine("3. Play the Mario Theme on your PC buzzer");

            //stores the users selection
            int selectedGame = int.Parse(Console.ReadLine());

            //switches to load game chosen by user
            if (selectedGame == 1)
                TicTacToe.TicTacToeMain(args);
            else if (selectedGame == 2)
                DartThrowCounter.PlayGame();
            else if (selectedGame == 3)
                Mario.PlayMario();
        }
    }
}

