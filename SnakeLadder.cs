using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
   
  public class Snake_Ladder
    {
        int firstPlayerPosition;

        Random random = new Random();
        public void game()
        {
            //First player starting from position 0
            firstPlayerPosition = 0;

            //Taking random value of Dice from 1-6
            int diceValue = random.Next(1, 7);
        }
    }
}
