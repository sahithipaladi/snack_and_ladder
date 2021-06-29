using System;

namespace snakeandladder
{
    class Program
    {
        // Starting position in the game is 0
        //The Player starts from 0 and palys the game till the winning spot 100 is achieved.
        public const int START = 0;
        public const int FINISH = 100;
        public static Random random = new Random();

        static int Roll_Dice()
        {
            // random value is given to palyer's dice
            return random.Next(1, 7);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake and Ladder game.");
            // player initial position
            int player_position = 0;
            Console.WriteLine("Player current position is " + player_position);

            // player rolls the dice and gets the value
            int player_Roll_Dice = Roll_Dice();
            Console.WriteLine("Player Dice value is " + player_Roll_Dice);
        }

    }
}

