using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladder
{
    class Player
    {
        public int player_position, player_Next_Position, dice_roll_count;
        public string Name;
        public Player(string Name)
        {
            this.Name = Name;
            this.player_position = 0;
            this.player_Next_Position = 0;
            this.dice_roll_count = 0;
        }

    }
}
