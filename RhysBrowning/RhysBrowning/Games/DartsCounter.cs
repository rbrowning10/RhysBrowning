using System;
using System.Collections.Generic;

namespace RhysBrowning.Games
{
    class DartThrowCounter
    {
        private static List<DartPlayer> dartsPlayers = new List<DartPlayer>();

        private static void AddPlayer(string name)
        {
            DartPlayer player = new DartPlayer(name);
            dartsPlayers.Add(player);
        }

        public static void PlayGame()
        {
            Console.Write("How many players? ");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write($"Enter player {i + 1}'s name: ");
                string playerName = Console.ReadLine();
                AddPlayer(playerName);
            }

            Console.WriteLine("Play darts!");
            foreach (DartPlayer name in dartsPlayers)
            {
                Console.WriteLine(name + ", it is your turn!");

                Console.WriteLine("First dart:");
                int score1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Second dart:");
                int score2 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Third dart:");
                int score3 = Int32.Parse(Console.ReadLine());

                PlayersTurn result = new PlayersTurn(score1, score2, score3);
                Console.WriteLine(result.CalculateScore());
            }
            Console.ReadKey();
        }

        class DartPlayer
        {
            public string Name { get; set; }

            public List<PlayersTurn> throwList = new List<PlayersTurn>();

            public DartPlayer(string name = "")
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        class PlayersTurn
        {
            private int throwOne;
            private int throwTwo;
            private int throwThree;

            public PlayersTurn(int throwOne = 0, int throwTwo = 0, int throwThree = 0)
            {
                this.throwOne = throwOne;
                this.throwTwo = throwTwo;
                this.throwThree = throwThree;
            }

            public int CalculateScore()
            {
                return throwOne + throwTwo + throwThree;
            }

            public override string ToString()
            {
                return string.Format("Your total score is {0}", CalculateScore());
            }
        }
    }
}
