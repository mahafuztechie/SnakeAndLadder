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
        int secondPlayerPosition = 0;

        const int MAX_POSITION = 100;
        int diceValue;
        int ranOption;
        int playerOnediceCount;
        int playerTwodiceCount;


        public void game()
        {

            while (firstPlayerPosition <= MAX_POSITION && secondPlayerPosition <= MAX_POSITION)
            {
                int checkPlayer = random.Next(0, 2);

                //playerOne
                if (checkPlayer == 0)
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
                                Console.WriteLine("u got a chance again to play");
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

                //playertwo
                else if (checkPlayer == 1)
                {
                    diceValue = random.Next(1, 7);
                    if (secondPlayerPosition >= 0 && secondPlayerPosition < 100)
                    {
                        ranOption = random.Next(0, 3);

                        if (ranOption == 0)
                        {
                            Console.WriteLine("no play");
                        }

                        else if (ranOption == 1)
                        {
                            if (secondPlayerPosition + diceValue <= 100)
                            {
                                secondPlayerPosition = secondPlayerPosition + diceValue;
                                playerTwodiceCount++;
                                Console.WriteLine("u got a chance again to play");
                                ranOption = random.Next(0, 3);

                                if (ranOption == 0)
                                {
                                    Console.WriteLine("no play");
                                }

                                else if (ranOption == 1)
                                {
                                    if (secondPlayerPosition + diceValue <= 100)
                                    {
                                        secondPlayerPosition = secondPlayerPosition + diceValue;
                                        playerTwodiceCount++;
                                        Console.WriteLine("Ladder");

                                    }

                                    else
                                    {
                                        Console.WriteLine(" remain in same position");
                                    }
                                }

                                else if (ranOption == 2)
                                {
                                    if (secondPlayerPosition - diceValue <= 0)
                                    {
                                        secondPlayerPosition = 0;
                                        playerTwodiceCount++;
                                    }
                                    else
                                    {
                                        secondPlayerPosition -= diceValue;
                                        playerTwodiceCount++;
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
                            if (secondPlayerPosition - diceValue <= 0)
                            {
                                secondPlayerPosition = 0;
                                playerTwodiceCount++;
                            }
                            else
                            {
                                secondPlayerPosition -= diceValue;
                                playerTwodiceCount++;
                                Console.WriteLine("Snake");
                            }
                        }
                        Console.WriteLine(secondPlayerPosition);
                        Console.WriteLine(playerTwodiceCount);
                    }
                }



            }
        }

    }
}