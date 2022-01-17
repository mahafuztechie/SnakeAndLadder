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
        int ranOption;
        public void game()
        {
            //First player starting from position 0
            firstPlayerPosition = 0;
            //Taking random value of Dice from 1-6
            int DiceValue = random.Next(1, 7);

            ranOption = random.Next(0, 3);

            if (ranOption == 0)
            {
                Console.WriteLine("no play");
                firstPlayerPosition += firstPlayerPosition;
            }
            else if (ranOption == 1)
            {
                Console.WriteLine("Ladder");
                firstPlayerPosition = firstPlayerPosition + DiceValue;
            }
            else
            {
                Console.WriteLine("Snake");
                firstPlayerPosition = firstPlayerPosition + DiceValue;
            }
        }
    }
}
