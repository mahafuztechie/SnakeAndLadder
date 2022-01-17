using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{


    public class SnakeLadder
    {
         
        Random random = new Random();

        int firstPlayerPosition = 0;
        const int MAX_POSITION = 100;
        int diceValue;
        int ranOption;
        int playerOnediceCount;

        public void game()
        {

            while (firstPlayerPosition <= MAX_POSITION)
            {


                diceValue = random.Next(1, 7);
                if (firstPlayerPosition >= 0 && firstPlayerPosition < 100)
                {
                    ranOption = random.Next(0, 3);

                    if (ranOption == 0)
                    {
                        Console.WriteLine("no play");
                    }

                    else if (ranOption == 1)
                    {
                        if (firstPlayerPosition + diceValue <= 100)
                        {
                            firstPlayerPosition = firstPlayerPosition + diceValue;
                            playerOnediceCount++;
                            Console.WriteLine("u got a chnace again to play");
                            ranOption = random.Next(0, 3);

                            if (ranOption == 0)
                            {
                                Console.WriteLine("no play");
                            }

                            else if (ranOption == 1)
                            {
                                if (firstPlayerPosition + diceValue <= 100)
                                {
                                    firstPlayerPosition = firstPlayerPosition + diceValue;
                                    playerOnediceCount++;
                                    Console.WriteLine("Ladder");

                                }

                                else
                                {
                                    Console.WriteLine(" ramin in same position");
                                }
                            }

                            else if (ranOption == 2)
                            {
                                if (firstPlayerPosition - diceValue <= 0)
                                {
                                    firstPlayerPosition = 0;
                                    playerOnediceCount++;
                                }
                                else
                                {
                                    firstPlayerPosition -= diceValue;
                                    playerOnediceCount++;
                                    Console.WriteLine("Snake");
                                }
                            }

                        }

                        else
                        {
                            Console.WriteLine(" remain in same position");
                        }
                    }
                  
                    else if (ranOption == 2)
                    {
                        if (firstPlayerPosition - diceValue <= 0)
                        {
                            firstPlayerPosition = 0;
                            playerOnediceCount++;
                        }
                        else
                        {
                            firstPlayerPosition -= diceValue;
                            playerOnediceCount++;
                            Console.WriteLine("Snake");
                        }
                    }
                    Console.WriteLine(firstPlayerPosition);
                    Console.WriteLine(playerOnediceCount);
                }
            }

        }

    } }