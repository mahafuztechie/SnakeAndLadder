using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{


    public class Snake_Ladder
    {
        int FirstPlayerPosition = 0;
        int MAX_POSITION = 100;

        Random random = new Random();
        int ranOption;
        public void game()
        {
            //First player starting from position 0
            FirstPlayerPosition = 0;

            //Creating while loop to reach the maximum value
            while (FirstPlayerPosition <= MAX_POSITION)
            {
                //Taking random value of Dice from 1-6
                int DiceValue = random.Next(1, 7);

                ranOption = random.Next(0, 3);

                if (ranOption == 0)
                {
                    Console.WriteLine("no play");
                    FirstPlayerPosition += FirstPlayerPosition;
                }
                else if (ranOption == 1)
                {
                    Console.WriteLine("Ladder");
                    FirstPlayerPosition = FirstPlayerPosition + DiceValue;

                    if (FirstPlayerPosition + DiceValue <= 100)
                    {
                        FirstPlayerPosition = FirstPlayerPosition + DiceValue;

                        Console.WriteLine("Ladder");

                    }

                    else
                    {
                        Console.WriteLine(" ramin in same position");
                    }
                }
                else if (ranOption == 2)
                {
                    Console.WriteLine("Snake");
                    FirstPlayerPosition = FirstPlayerPosition - DiceValue;
                }
                else
                {
                    Console.WriteLine("Not valid move");
                }
            }
        }
    }
}