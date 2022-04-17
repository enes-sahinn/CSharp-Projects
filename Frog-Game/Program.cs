using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Frog_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; int d = 0; int e = 0; int g = 0; int z = 0; int y = 0; int v = 0; int q = 0;
            int b = 0; int c = 0; int f = 0; int h = 0; int x = 0; int w = 0; int t = 0; int o = 0;
            bool flag_game_win = true;
            bool flag_game_end = false;
            //---------------------------Creating arrays and giving them values-------------------------------------------
            char[] road_1 = new char[85];
            char[] road_2 = new char[85];
            char[] road_3 = new char[85];
            char[] road_4 = new char[85];
            char[] road_5 = new char[85];
            char[] road_6 = new char[85];
            char[] Car = new char[12];
            for (int i = 25; i <= 75; i++)
            {
                road_2[i] = '▓';
                road_4[i] = '▓';
                road_1[i] = '▒';
                road_3[i] = '▒';
                road_5[i] = '~';
                road_6[i] = '~';
            }
            for (int i = 0; i <= 22; i++)
            {
                road_2[i] = ' ';
                road_4[i] = ' ';
                road_1[i] = ' ';
                road_3[i] = ' ';
                road_5[i] = ' ';
            }
            Console.CursorVisible = false;
            Random r = new Random();


            //-------------------------------------------------Creating the cars.------------------------------------------------------------------
            int level = 1;
            int time = 60;
            int score = 0;
            int lives = 3;
            for (int k = 0; k < level * 2; k++)
            {

                int r_lenght = r.Next(2, 5);
                int r_road = r.Next(9, 11);
                int r_place = r.Next(25, 71);
                if (r_road == 9 & road_3[(r_place + r_lenght)] == '▒' & road_3[r_place] == '▒' & road_3[(r_place + (r_lenght + 1))] == '▒' & road_3[(r_place - 1)] == '▒' & road_3[(r_place) + 1] == '▒')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_3[r_place] = '2';
                        r_place = r_place + 1;

                    }
                }

                else if (r_road == 10 & road_4[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_4[(r_place + (r_lenght + 1))] == '▓' & road_4[(r_place - 1)] == '▓' & road_4[(r_place) + 1] == '▓')
                {
                    for (int j = 0; j < r_lenght; j++)
                    {
                        road_4[r_place] = '2';
                        r_place = r_place + 1;

                    }
                }
                else
                    k--;

            }
            for (int k = 0; k < level * 2; k++)
            {

                int r_lenght = r.Next(2, 5);
                int r_road = r.Next(7, 9);
                int r_place = r.Next(25, 71);
                if (r_road == 7 & road_1[(r_place + r_lenght)] == '▒' & road_1[r_place] == '▒' & road_1[(r_place + (r_lenght + 1))] == '▒' & road_1[(r_place - 1)] == '▒' & road_1[(r_place) + 1] == '▒')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_1[r_place] = '2';
                        r_place = r_place + 1;

                    }
                }

                else if (r_road == 8 & road_2[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_2[(r_place + (r_lenght + 1))] == '▓' & road_2[(r_place - 1)] == '▓' & road_2[(r_place) + 1] == '▓')
                {
                    for (int j = 0; j < r_lenght; j++)
                    {
                        road_2[r_place] = '2';
                        r_place = r_place + 1;

                    }
                }
                else
                    k--;

            }
            for (int i = 0; i < 12 - (level * 2); i++)
            {

                int r_lenght = r.Next(2, 5);
                int r_road = r.Next(7, 9);
                int r_place = r.Next(25, 71);

                if (r_road == 7 & road_1[(r_place + r_lenght)] == '▒' & road_1[r_place] == '▒' & road_1[(r_place + (r_lenght + 1))] == '▒' & road_1[(r_place - 1)] == '▒' & road_1[(r_place) + 1] == '▒')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_1[r_place] = '1';
                        r_place = r_place + 1;

                    }
                }
                else if (r_road == 8 & road_2[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_2[(r_place + (r_lenght + 1))] == '▓' & road_2[(r_place - 1)] == '▓' & road_2[(r_place) + 1] == '▓')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_2[r_place] = '1';
                        r_place = r_place + 1;
                    }

                }
                else
                    i--;
            }
            for (int i = 0; i < 12 - (level * 2); i++)
            {
                int r_lenght = r.Next(2, 5);
                int r_road = r.Next(9, 11);
                int r_place = r.Next(25, 71);
                if (r_road == 9 & road_3[(r_place + r_lenght)] == '▒' & road_3[r_place] == '▒' & road_3[(r_place + (r_lenght + 1))] == '▒' & road_3[(r_place - 1)] == '▒' & road_3[(r_place) + 1] == '▒')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_3[r_place] = '1';
                        r_place = r_place + 1;
                    }
                }
                else if (r_road == 10 & road_4[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_4[(r_place + (r_lenght + 1))] == '▓' & road_4[(r_place - 1)] == '▓' & road_4[(r_place) + 1] == '▓')
                {
                    for (int l = 0; l < r_lenght; l++)
                    {
                        road_4[r_place] = '1';
                        r_place = r_place + 1;

                    }
                }
                else
                    i--;
            }

            //----------------------------------------------------------------Frogs movement-----------------------------------------------------------------------------
            bool flag_level_end = false;
            road_6[51] = 'F';
            string direction = "";
            int moves = 0;
            int frogx = 51;
            int frogy = 11;
            ConsoleKeyInfo cki;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.RightArrow && frogx < 75)
                    {
                        if (frogy == 11)
                        {
                            

                            road_6[frogx + 1] = road_6[frogx];
                            road_6[frogx] = '~';
                        }

                        if (frogy == 10)
                        {
                            if (road_4[frogx + 1] == '1' || road_4[frogx + 1] == '2')
                            {
                                road_4[frogx] = '▓';
                                lives--;
                                frogx = 50;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                           
                            
                                road_4[frogx + 1] = road_4[frogx];
                                road_4[frogx] = '▓';
                            
                        }
                        if (frogy == 9)
                        {

                            if (road_3[frogx + 1] == '1' || road_3[frogx + 1] == '2')
                            {
                                road_3[frogx] = '▒';
                                lives--;
                                frogx = 50;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_3[frogx + 1] = road_3[frogx];
                                road_3[frogx] = '▒';
                            
                        }
                        if (frogy == 8)
                        {
                            if (road_2[frogx + 1] == '1' || road_2[frogx + 1] == '2')
                            {
                                road_2[frogx] = '▓';
                                lives--;
                                frogx = 50;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_2[frogx + 1] = road_2[frogx];
                                road_2[frogx] = '▓';
                            
                        }
                        if (frogy == 7)
                        {
                            if (road_1[frogx + 1] == '1' || road_1[frogx + 1] == '2')
                            {
                                road_1[frogx] = '▒';
                                lives--;
                                frogx = 50;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_1[frogx + 1] = road_1[frogx];
                                road_1[frogx] = '▒';
                            
                        }
                        frogx++;
                        moves = moves + 1;
                    }
                    if (cki.Key == ConsoleKey.LeftArrow && frogx > 25)
                    {
                        if (frogy == 11)
                        {
                           
                                road_6[frogx - 1] = road_6[frogx];
                                road_6[frogx] = '~';
                            
                        }
                        if (frogy == 10)
                        {
                            if (road_4[frogx - 1] == '1' || road_4[frogx - 1] == '2')
                            {
                                road_4[frogx] = '▓';
                                lives--;
                                frogx = 52;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_4[frogx - 1] = road_4[frogx];
                                road_4[frogx] = '▓';
                            
                        }
                        if (frogy == 9)
                        {
                            if (road_3[frogx - 1] == '1' || road_3[frogx - 1] == '2')
                            {
                                road_3[frogx] = '▒';
                                lives--;
                                frogx = 52;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_3[frogx - 1] = road_3[frogx];
                                road_3[frogx] = '▒';
                            
                        }
                        if (frogy == 8)
                        {
                            if (road_2[frogx - 1] == '1' || road_2[frogx - 1] == '2')
                            {
                                road_2[frogx] = '▓';
                                lives--;
                                frogx = 52;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_2[frogx - 1] = road_2[frogx];
                                road_2[frogx] = '▓';
                            
                        }
                        if (frogy == 7)
                        {
                            if (road_1[frogx - 1] == '1' || road_1[frogx - 1] == '2')
                            {
                                road_1[frogx] = '▒';
                                lives--;
                                frogx = 52;
                                frogy = 11;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                                road_1[frogx - 1] = road_1[frogx];
                                road_1[frogx] = '▒';
                            
                        }

                        frogx--;
                        moves = moves + 1;
                    }
                    if (cki.Key == ConsoleKey.DownArrow && frogy < 11)
                    {

                        if (frogy == 10)
                        {
                            road_6[frogx] = road_4[frogx];
                            road_4[frogx] = '▓';
                        }
                        if (frogy == 9)
                        {
                            if (road_4[frogx] == '1' || road_4[frogx] == '2')
                            {
                                road_3[frogx] = '▒';
                                lives--;
                                frogx = 51;
                                frogy = 10;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                           
                                road_4[frogx] = road_3[frogx];
                                road_3[frogx] = '▒';
                            
                        }
                        if (frogy == 8)
                        {
                            if (road_3[frogx] == '1' || road_3[frogx] == '2')
                            {
                                road_2[frogx] = '▓';
                                lives--;
                                frogx = 51;
                                frogy = 10;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            road_3[frogx] = road_2[frogx];
                            road_2[frogx] = '▓';
                        }
                        if (frogy == 7)
                        {
                            if (road_2[frogx] == '1' || road_2[frogx] == '2')
                            {
                                road_1[frogx] = '▒';
                                lives--;
                                frogx = 51;
                                frogy = 10;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                            road_2[frogx] = road_1[frogx];
                            road_1[frogx] = '▒';
                        }
                        frogy++;
                        moves = moves + 1;
                    }
                    if (cki.Key == ConsoleKey.UpArrow && frogy > 5)
                    {
                        if (frogy == 11)
                        {
                            if(road_4[frogx] == '1' ||road_4[frogx] == '2')
                            {
                                road_6[frogx] = '~';
                                lives--;
                                frogx = 51;
                                frogy = 12;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            
                            road_4[frogx] = road_6[frogx];
                            road_6[frogx] = '~';
                        }
                        if (frogy == 10)
                        {
                            if (road_3[frogx] == '1' || road_3[frogx] == '2')
                            {
                                road_4[frogx] = '▓';
                                lives--;
                                frogx = 51;
                                frogy = 12;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            road_3[frogx] = road_4[frogx];
                            road_4[frogx] = '▓';
                        }
                        if (frogy == 9)
                        {
                            if (road_2[frogx] == '1' || road_2[frogx] == '2')
                            {
                                road_3[frogx] = '▒';
                                lives--;
                                frogx = 51;
                                frogy = 12;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            road_2[frogx] = road_3[frogx];
                            road_3[frogx] = '▒';
                        }
                        if (frogy == 8)
                        {
                            if (road_1[frogx] == '1' || road_1[frogx] == '2')
                            {
                                road_2[frogx] = '▓';
                                lives--;
                                frogx = 51;
                                frogy = 12;
                                road_6[51] = 'F';
                                Thread.Sleep(1250);
                                if (lives == 0)
                                {
                                    flag_game_end = true;
                                    break;
                                }
                            }
                            road_1[frogx] = road_2[frogx];
                            road_2[frogx] = '▓';
                        }
                        if (frogy == 7)
                        {
                            flag_level_end = true;
                        }
                        frogy--;
                        moves = moves + 1;
                    }
                    if (cki.Key == ConsoleKey.UpArrow) { direction = "Up"; }
                    else if (cki.Key == ConsoleKey.DownArrow) { direction = "Down"; }
                    else if (cki.Key == ConsoleKey.LeftArrow) { direction = "Left"; }
                    else if (cki.Key == ConsoleKey.RightArrow) { direction = "Right"; }
                    else direction = " ";
                    Thread.Sleep(50);



                }
                if (flag_level_end == true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 15);
                    Console.WriteLine("Congradulations ! You have beaten the  " + level + ". level ! ");
                    Thread.Sleep(2500);
                    Console.Clear();
                    level++;
                    if (level == 7) 
                    {
                        flag_game_win = true;
                        break;
                    }
                    lives++;
                    score = score + time;
                    time = 60;
                    frogx = 51;
                    frogy = 11;
                    for (int i = 25; i <= 75; i++)
                    {
                        road_2[i] = '▓';
                        road_4[i] = '▓';
                        road_1[i] = '▒';
                        road_3[i] = '▒';
                        road_5[i] = '~';
                        road_6[i] = '~';
                    }

                    for (int k = 0; k < level * 2; k++)
                    {

                        int r_lenght = r.Next(2, 5);
                        int r_road = r.Next(9, 11);
                        int r_place = r.Next(25, 71);
                        if (r_road == 9 & road_3[(r_place + r_lenght)] == '▒' & road_3[r_place] == '▒' & road_3[(r_place + (r_lenght + 1))] == '▒' & road_3[(r_place - 1)] == '▒' & road_3[(r_place) + 1] == '▒')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_3[r_place] = '2';
                                r_place = r_place + 1;

                            }
                        }

                        else if (r_road == 10 & road_4[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_4[(r_place + (r_lenght + 1))] == '▓' & road_4[(r_place - 1)] == '▓' & road_4[(r_place) + 1] == '▓')
                        {
                            for (int j = 0; j < r_lenght; j++)
                            {
                                road_4[r_place] = '2';
                                r_place = r_place + 1;

                            }
                        }
                        else
                            k--;

                    }
                    for (int k = 0; k < level * 2; k++)
                    {

                        int r_lenght = r.Next(2, 5);
                        int r_road = r.Next(7, 9);
                        int r_place = r.Next(25, 71);
                        if (r_road == 7 & road_1[(r_place + r_lenght)] == '▒' & road_1[r_place] == '▒' & road_1[(r_place + (r_lenght + 1))] == '▒' & road_1[(r_place - 1)] == '▒' & road_1[(r_place) + 1] == '▒')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_1[r_place] = '2';
                                r_place = r_place + 1;

                            }
                        }

                        else if (r_road == 8 & road_2[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_2[(r_place + (r_lenght + 1))] == '▓' & road_2[(r_place - 1)] == '▓' & road_2[(r_place) + 1] == '▓')
                        {
                            for (int j = 0; j < r_lenght; j++)
                            {
                                road_2[r_place] = '2';
                                r_place = r_place + 1;

                            }
                        }
                        else
                            k--;

                    }
                    for (int i = 0; i < 12 - (level * 2); i++)
                    {

                        int r_lenght = r.Next(2, 5);
                        int r_road = r.Next(7, 9);
                        int r_place = r.Next(25, 71);

                        if (r_road == 7 & road_1[(r_place + r_lenght)] == '▒' & road_1[r_place] == '▒' & road_1[(r_place + (r_lenght + 1))] == '▒' & road_1[(r_place - 1)] == '▒' & road_1[(r_place) + 1] == '▒')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_1[r_place] = '1';
                                r_place = r_place + 1;

                            }
                        }
                        else if (r_road == 8 & road_2[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_2[(r_place + (r_lenght + 1))] == '▓' & road_2[(r_place - 1)] == '▓' & road_2[(r_place) + 1] == '▓')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_2[r_place] = '1';
                                r_place = r_place + 1;
                            }

                        }
                        else
                            i--;
                    }
                    for (int i = 0; i < 12 - (level * 2); i++)
                    {
                        int r_lenght = r.Next(2, 5);
                        int r_road = r.Next(9, 11);
                        int r_place = r.Next(25, 71);
                        if (r_road == 9 & road_3[(r_place + r_lenght)] == '▒' & road_3[r_place] == '▒' & road_3[(r_place + (r_lenght + 1))] == '▒' & road_3[(r_place - 1)] == '▒' & road_3[(r_place) + 1] == '▒')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_3[r_place] = '1';
                                r_place = r_place + 1;
                            }
                        }
                        else if (r_road == 10 & road_4[(r_place + r_lenght)] == '▓' & road_4[r_place] == '▓' & road_4[(r_place + (r_lenght + 1))] == '▓' & road_4[(r_place - 1)] == '▓' & road_4[(r_place) + 1] == '▓')
                        {
                            for (int l = 0; l < r_lenght; l++)
                            {
                                road_4[r_place] = '1';
                                r_place = r_place + 1;

                            }
                        }
                        else
                            i--;
                    }
                    road_6[51] = 'F';
                    flag_level_end = false;
                }
                //--------------------------------Writing score, time, lives, frongs movement count and the frogs last movement.------------------------------------------
                Console.SetCursorPosition(83, 3);
                Console.WriteLine("                              ");
                Console.SetCursorPosition(83, 3);
                Console.WriteLine("Frogs Direction : " + direction);
                Console.SetCursorPosition(70, 3);
                Console.WriteLine("Moves : " + moves);
                Console.SetCursorPosition(17, 3);
                Console.WriteLine("Lives :  " + lives);
                Console.SetCursorPosition(50, 3);
                Console.WriteLine("Score : " + score);
                Console.SetCursorPosition(32, 3);
                Console.WriteLine("Time : " + time);
                //-------------------------------------------Writing the cars and the roads------------------------------------------------------------------
                //First and second roads car movement.
                for (int m = 25; m <= 75; m++)
                {
                    if (road_1[m] == '1' && time % 2 == 0)
                    {
                        if (road_1[m - 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_1[m - 1] = road_1[m];
                        road_1[m] = '▒';
                    }
                    else if (road_1[m] == '2')
                    {
                        if (road_1[m - 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_1[m - 1] = road_1[m];
                        road_1[m] = '▒';
                    }
                    if (road_2[m] == '1' && time % 2 == 0)
                    {
                        if (road_2[m - 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_2[m - 1] = road_2[m];
                        road_2[m] = '▓';
                    }
                    else if (road_2[m] == '2')
                    {
                        if (road_2[m - 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_2[m - 1] = road_2[m];
                        road_2[m] = '▓';
                    }


                }
                if (road_1[25] == '1' && road_1[26] == '▒')
                {
                    
                    a = r.Next(2, 5);
                    b = 0;
                }
                if (b < a)
                {
                    road_1[75] = '1';
                    b++;
                }
                if (road_1[25] == '2' && road_1[26] == '▒')
                {

                    c = r.Next(2, 5);
                    d = 0;
                }
                if (d < c)
                {
                    road_1[75] = '2';
                    d++;
                }
               
                if (road_2[25] == '1' && road_2[26] == '▓')
                {
                    
                    e = r.Next(2, 5);
                    f = 0;
                }
                if (f < e)
                {
                    road_2[75] = '1';
                    f++;
                }
                if (road_2[25] == '2' && road_2[26] == '▓')
                {

                    g = r.Next(2, 5);
                    h = 0;
                }
                if (h < g)
                {
                    road_2[75] = '2';
                    h++;
                }
                //Third and fourth roads car movement.
                for (int m = 75; m > 24; m--)
                {
                    if (road_3[m] == '1' && time % 2 == 0)
                    {
                        if (road_3[m + 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_3[m + 1] = road_3[m];
                        road_3[m] = '▒';
                    }
                    else if (road_3[m] == '2')
                    {
                        if (road_3[m + 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_3[m + 1] = road_3[m];
                        road_3[m] = '▒';
                    }
                    if (road_4[m] == '1' && time % 2 == 0)
                    {
                        if (road_4[m + 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_4[m + 1] = road_4[m];
                        road_4[m] = '▓';
                    }
                    else if (road_4[m] == '2')
                    {
                        if (road_4[m + 1] == 'F')
                        {
                            lives--;
                            if (lives == 0)
                            {
                                flag_game_end = true;
                                break;
                            }
                            frogx = 51;
                            frogy = 11;
                            Thread.Sleep(1250);
                            road_6[51] = 'F';
                        }
                        road_4[m + 1] = road_4[m];
                        road_4[m] = '▓';
                    }
                }
                
                if (road_3[75] == '1' && road_3[74] == '▒')
                {
                    
                    z = r.Next(2, 5);
                    y = 0;
                }
                if (y < z)
                {
                    road_3[25] = '1';
                    y++;
                }
                
                if (road_3[75] == '2' && road_3[74] == '▒')
                {
                    
                    v = r.Next(2, 5);
                    q = 0;
                }
                if (q < v)
                {
                    road_3[25] = '1';
                    q++;
                }
                if (road_4[75] == '1' && road_4[74] == '▓')
                {

                    x = r.Next(2, 5);
                    w = 0;
                }
                if (w < x)
                {
                    road_4[25] = '1';
                    w++;
                }
                if (road_4[75] == '2' && road_4[74] == '▓')
                {

                    t = r.Next(2, 5);
                    o = 0;
                }
                if (o < t)
                {
                    road_4[25] = '2';
                    o++;
                }
                road_1[76] = '<';
                road_1[77] = '<';
                road_1[78] = '<';
                road_2[76] = '<';
                road_2[77] = '<';
                road_2[78] = '<';
                road_3[76] = '>';
                road_3[77] = '>';
                road_3[78] = '>';
                road_4[76] = '>';
                road_4[77] = '>';
                road_4[78] = '>';
                road_1[23] = 'R';
                road_1[24] = '1';
                road_2[23] = 'R';
                road_2[24] = '2';
                road_3[23] = 'R';
                road_3[24] = '3';
                road_4[23] = 'R';
                road_4[24] = '4';
                road_5[23] = ' ';
                road_5[24] = ' ';
                road_6[23] = ' ';
                road_6[24] = ' ';
                //Writing the arrays.
                for (int i = 6; i <= 11; i++)
                {
                    if (i == 6)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_5[j]);
                        }
                    }
                    if (i == 7)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_1[j]);
                        }
                    }
                    if (i == 9)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_3[j]);
                        }
                    }
                    if (i == 8)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_2[j]);
                        }
                    }
                    if (i == 10)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_4[j]);
                        }
                    }
                    if (i == 11)
                    {
                        for (int j = 0; j < 80; j++)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.WriteLine(road_6[j]);
                        }
                    }
                } time--;


                Thread.Sleep(100);
            }
            Console.Clear();
            if (flag_game_end == true)
            {
                Console.SetCursorPosition(43, 13);
                Console.WriteLine("GAME OVER");
                Thread.Sleep(4500);
            }
            if (flag_game_win == true)
            {
                Console.SetCursorPosition(43, 12);
                Console.WriteLine("YOU HAVE WON ! ! ! ");
                Thread.Sleep(4500);
            }
        }

    }
}



