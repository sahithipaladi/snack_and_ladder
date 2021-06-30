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
            // Number of players are created 
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");
            bool end_Game = false;
            Player current_Player = player1;


            //Repeats till the Player reaches the winning position 100.
            while (!end_Game)
            {
                // player rolls the dice and gets the value
                int player_Roll_Dice = Roll_Dice();

                // number of times the dice was played is counted
                current_Player.dice_roll_count++;

                // The Player then checks for a Option. They are No_Play,Ladder and Snake.
                int player_move = Player_Move_Option(player_Roll_Dice);
                if (current_Player.player_position + player_move == FINISH)
                {
                    current_Player.player_Next_Position = FINISH;
                    end_Game = true;
                }
                else if (current_Player.player_position + player_move > FINISH)
                    current_Player.player_Next_Position = current_Player.player_position;
                else
                    current_Player.player_Next_Position = current_Player.player_position + player_move;

                if (current_Player.player_Next_Position < START)
                    current_Player.player_position = START;
                else
                    current_Player.player_position = current_Player.player_Next_Position;

                // Player current position After rolling the Dice
                Console.WriteLine(current_Player.Name + " current position after rolling the Dice is " + current_Player.player_position);
                if (!end_Game && player_move > 0)
                    continue;
                else
                {
                    if (current_Player == player1)
                        current_Player = player2;
                    else
                        current_Player = player1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Winner is " + current_Player.Name);
            Console.WriteLine("Total Number of Dice Roll in the game by " + current_Player.Name + " is " + current_Player.dice_roll_count);


        }

    }
}

