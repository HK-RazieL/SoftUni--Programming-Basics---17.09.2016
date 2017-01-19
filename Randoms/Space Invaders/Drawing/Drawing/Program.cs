using System;
using System.Threading;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 40;
            Console.BufferWidth = 40;
            Console.WindowHeight = 21;
            Console.BufferHeight = 21;
            Console.CursorVisible = false;

            int lastLine = 19;
            int playerVerticalPos = (39 / 2) - 1;

            int projectileX = 0;
            int projectileY = 0;
            bool projectileVisibility = false;

            Random shuffle = new Random();

            int firstObjX = shuffle.Next(40);
            int firstObjY = 0;
            bool firstObjDestroyed = false;

            int secondObjX = shuffle.Next(40);
            int secondObjY = 0;
            bool secondObjDestroyed = false;

            int thirdObjX = shuffle.Next(40);
            int thirdObjY = 0;
            bool thirdObjDestroyed = false;

            int score = 0;
            for (int j = 0; j == 0;)
            {
                for (int i = 0; i < 1;)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo pressedKey = Console.ReadKey();

                        switch (pressedKey.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                {
                                    if (playerVerticalPos > 0)
                                    {
                                        playerVerticalPos--;
                                    }
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                {
                                    if (playerVerticalPos < 39)
                                    {
                                        playerVerticalPos++;
                                    }
                                }
                                break;
                            case ConsoleKey.Spacebar:
                                {
                                    projectileY = lastLine - 1;
                                    projectileX = playerVerticalPos;

                                    projectileVisibility = true;
                                }
                                break;
                        }
                    }

                    Console.SetCursorPosition(playerVerticalPos, lastLine);
                    Console.Write("^");

                    if (projectileVisibility)
                    {
                        Console.SetCursorPosition(projectileX, projectileY);
                        Console.Write("*");

                        if (projectileY > 0)
                        {
                            projectileY--;

                            if (projectileX == firstObjX && projectileY == firstObjY)
                            {
                                score += 50;
                                firstObjDestroyed = true;
                            }

                            if (projectileX == secondObjX && projectileY == secondObjY)
                            {
                                score += 50;
                                secondObjDestroyed = true;
                            }

                            if (projectileX == thirdObjX && projectileY == thirdObjY)
                            {
                                score += 50;
                                thirdObjDestroyed = true;
                            }
                        }
                        else
                        {
                            projectileVisibility = false;
                        }
                    }

                    if (!firstObjDestroyed)
                    {
                        Console.SetCursorPosition(firstObjX, firstObjY);
                        Console.Write("-");
                    }

                    if (!secondObjDestroyed)
                    {
                        Console.SetCursorPosition(secondObjX, secondObjY);
                        Console.Write("-");
                    }

                    if (!thirdObjDestroyed)
                    {
                        Console.SetCursorPosition(thirdObjX, thirdObjY);
                        Console.Write("-");
                    }

                    if (firstObjDestroyed && secondObjDestroyed && thirdObjDestroyed)
                    {
                        i++;
                    }

                    Thread.Sleep(50);
                    Console.Clear();

                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                    Console.Write("Score: " + score);
                }

               
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.Write("GAME OVER!");
            }
        }
    }
}
