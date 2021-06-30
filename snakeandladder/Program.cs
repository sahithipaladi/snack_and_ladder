using System;

namespace snakeandladder
{
    class Program
    {
        // Starting position in the game is 0
        //The Player starts from 0 and palys the game till the winning spot 100 is achieved.
        public const int START = 0;
        public const int FINISH = 100;
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public static Random random = new Random();

        public static int Roll_Dice()
        {
            // random value is given to palyer's dice
            return random.Next(1, 7);
        }
        public static int Player_Move_Option(int player_Roll_Dice)
        {
            // Player Option is gentrated..
            int check_Player_Option = random.Next(0, 3);
            int player_Move = 0;
            switch (check_Player_Option)
            {
                case LADDER:
                    player_Move = player_Roll_Dice;
                    break;
                case SNAKE:
                    player_Move = -player_Roll_Dice;
                    break;
                default:
                    break;
            }
            return player_Move;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake and Ladder game.");
            // player initial position
            int player_position = 0, player_Next_Position;

            int dice_roll_count = 0;

            //Repeats till the Player reaches the winning position 100.
            while (player_position < FINISH)
            {
                // player rolls the dice and gets the value
                int player_Roll_Dice = Roll_Dice();

                // number of times the dice was played is counted
                dice_roll_count++;

                // The Player then checks for a Option. They are No_Play,Ladder and Snake.
                int player_move = Player_Move_Option(player_Roll_Dice);

                if (player_position + player_move > FINISH)
                    player_Next_Position = player_position;
                else
                    player_Next_Position = player_position + player_move;

                if (player_Next_Position < START)
                    player_position = START;
                else
                    player_position = player_Next_Position;

                // Player current position After rolling the Dice
                Console.WriteLine("Player current position After rolling the Dice is " + player_position);
            }
            Console.WriteLine();
            Console.WriteLine("Player current position After the game is " + player_position);
            Console.WriteLine("Total Number of Dice Roll in the game is " + dice_roll_count);



        }

    }
}

