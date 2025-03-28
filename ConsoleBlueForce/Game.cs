using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleBlueForce
{
    public class Enemy
    {
        public string enemychar = "v";
        public int enemyplacex { get; set; }
        public int oldenemyplacey { get; set; }
        public int newenemyplacey { get; set; }
    }
    internal class Game
    {
        public static void Main()
        {
            string player = "^";
            int oldplayerplace = 0;
            int newplayerplace = 11;
            int playerhealth = 5;
            int playerscore = 0;
            Random rand = new Random();

            Console.CursorVisible = false;

            string[,] GroundMatrix = new string[11, 21]
            {
                        {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","*"},
                        {"*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*","*"}
            };

            Enemy enemy1 = new Enemy();
            EnemyLocate(enemy1);
            Enemy enemy2 = new Enemy();
            EnemyLocate(enemy2);
            Enemy enemy3 = new Enemy();
            EnemyLocate(enemy3);
            Enemy enemy4 = new Enemy();
            EnemyLocate(enemy4);
            Enemy enemy5 = new Enemy();
            EnemyLocate(enemy5);
            Enemy enemy6 = new Enemy();
            EnemyLocate(enemy6);
            Enemy enemy7 = new Enemy();
            EnemyLocate(enemy7);
            Enemy enemy8 = new Enemy();
            EnemyLocate(enemy8);
            Enemy enemy9 = new Enemy();
            EnemyLocate(enemy9);
            Enemy enemy10 = new Enemy();
            EnemyLocate(enemy10);

            void EnemyLocate(Enemy enemy)
            {
                enemy.enemyplacex = rand.Next(1, 19);
                enemy.oldenemyplacey = rand.Next(1, 5);
                enemy.newenemyplacey = enemy.oldenemyplacey;
            }

            System.Timers.Timer refreshrate;
            refreshrate = new System.Timers.Timer();
            refreshrate.Interval = 150;
            refreshrate.Elapsed += OnTimedEvent;
            refreshrate.AutoReset = true;
            refreshrate.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                Console.Clear();

                if (playerhealth >= 0)
                {
                    playerscore++;

                    GroundMatrix[8, oldplayerplace] = " ";
                    GroundMatrix[8, newplayerplace] = player;

                    for (int i = 1; i < GroundMatrix.GetLength(1)-1; i++)
                    {
                        GroundMatrix[9,i] = " ";
                    }

                    enemy1.newenemyplacey ++;
                    GroundMatrix[enemy1.newenemyplacey, enemy1.enemyplacex] = enemy1.enemychar;
                    GroundMatrix[enemy1.newenemyplacey-1, enemy1.enemyplacex] = " ";
                    if (enemy1.newenemyplacey == 8 && enemy1.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy1.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy1);
                    }

                    enemy2.newenemyplacey ++;
                    GroundMatrix[enemy2.newenemyplacey, enemy2.enemyplacex] = enemy2.enemychar;
                    GroundMatrix[enemy2.newenemyplacey-1, enemy2.enemyplacex] = " ";
                    if (enemy2.newenemyplacey == 8 && enemy2.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy2.newenemyplacey == 9)
                    {
                        EnemyLocate(enemy2);
                    }

                    enemy3.newenemyplacey ++;
                    GroundMatrix[enemy3.newenemyplacey, enemy3.enemyplacex] = enemy3.enemychar;
                    GroundMatrix[enemy3.newenemyplacey-1, enemy3.enemyplacex] = " ";
                    if (enemy3.newenemyplacey == 8 && enemy3.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy3.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy3);
                    }

                    enemy4.newenemyplacey++;
                    GroundMatrix[enemy4.newenemyplacey, enemy4.enemyplacex] = enemy4.enemychar;
                    GroundMatrix[enemy4.newenemyplacey - 1, enemy4.enemyplacex] = " ";
                    if (enemy4.newenemyplacey == 8 && enemy4.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy4.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy4);
                    }

                    enemy5.newenemyplacey++;
                    GroundMatrix[enemy5.newenemyplacey, enemy5.enemyplacex] = enemy5.enemychar;
                    GroundMatrix[enemy5.newenemyplacey - 1, enemy5.enemyplacex] = " ";
                    if (enemy5.newenemyplacey == 8 && enemy5.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy5.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy5);
                    }

                    enemy6.newenemyplacey++;
                    GroundMatrix[enemy6.newenemyplacey, enemy6.enemyplacex] = enemy6.enemychar;
                    GroundMatrix[enemy6.newenemyplacey - 1, enemy6.enemyplacex] = " ";
                    if (enemy6.newenemyplacey == 8 && enemy6.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy6.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy6);
                    }

                    enemy7.newenemyplacey++;
                    GroundMatrix[enemy7.newenemyplacey, enemy7.enemyplacex] = enemy7.enemychar;
                    GroundMatrix[enemy7.newenemyplacey - 1, enemy7.enemyplacex] = " ";
                    if (enemy7.newenemyplacey == 8 && enemy7.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy7.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy7);
                    }

                    enemy8.newenemyplacey++;
                    GroundMatrix[enemy8.newenemyplacey, enemy8.enemyplacex] = enemy8.enemychar;
                    GroundMatrix[enemy8.newenemyplacey - 1, enemy8.enemyplacex] = " ";
                    if (enemy8.newenemyplacey == 8 && enemy8.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy8.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy8);
                    }

                    enemy9.newenemyplacey++;
                    GroundMatrix[enemy9.newenemyplacey, enemy9.enemyplacex] = enemy9.enemychar;
                    GroundMatrix[enemy9.newenemyplacey - 1, enemy9.enemyplacex] = " ";
                    if (enemy9.newenemyplacey == 8 && enemy9.enemyplacex == newplayerplace)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy9.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy9);
                    }

                    enemy10.newenemyplacey++;
                    GroundMatrix[enemy10.newenemyplacey, enemy10.enemyplacex] = enemy10.enemychar;
                    GroundMatrix[enemy10.newenemyplacey - 1, enemy10.enemyplacex] = " ";
                    if (enemy10.newenemyplacey == newplayerplace && enemy10.enemyplacex == 8)
                    {
                        Console.Beep(300, 100);
                        playerhealth--;
                    }
                    if (enemy10.newenemyplacey == 9)
                    {
                        EnemyLocate (enemy10);
                    }
                }

                RefreshScreen();

            }

            void RefreshScreen()
            {
                if (playerhealth >= 0)
                {
                    for (int i = 0; i < GroundMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < GroundMatrix.GetLength(1); j++)
                        {
                            Console.Write(GroundMatrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Health : " + playerhealth);
                    Console.WriteLine("Score : " + playerscore);
                }
                else
                {
                    Console.WriteLine("your score is : " + playerscore);
                    Console.WriteLine("to play again press enter");
                }
                
            }

            void MovePlayer()
            {
                ConsoleKeyInfo input;

                if (playerhealth >= 0)
                {
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.RightArrow)
                    {
                        Console.Beep(500,100);
                        oldplayerplace = newplayerplace;
                        newplayerplace++;
                        if (newplayerplace >= 19)
                        {
                            newplayerplace = 19;
                        }
                    }
                    if (input.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Beep(500, 100);
                        oldplayerplace = newplayerplace;
                        newplayerplace--;
                        if (newplayerplace <= 1)
                        {
                            newplayerplace = 1;
                        }
                    }
                    MovePlayer();
                }
                if (playerhealth <= 0)
                {
                    Console.Clear();
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Enter)
                    {
                        playerscore = 0;
                        playerhealth = 5;
                        MovePlayer();
                    }
                }
            }

            if (playerhealth > 0)
            {
                MovePlayer();
            }
        }
    }
}
