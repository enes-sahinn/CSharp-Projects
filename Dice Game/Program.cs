using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                /* VARİABLES */
                string name;
                string name1 = "Cem AK";
                string name2 = "Sibel YAMAN";
                string getpoints = "";
                int point1 = 30;
                int point2 = 18;
                int dice1 = 0;
                int dice2 = 0;
                int dice3 = 0;
                int dice4 = 0;
                int point = 0;
                bool a = true;
                Random random = new Random();

                /* MENU SCREEN */
                Console.WriteLine("----------//MENU\\\\----------");
                Console.WriteLine("PLEASE ENTER YOUR NAME\n");
                name = Console.ReadLine();
                Console.WriteLine("1-)GAME MODE 1: THROW DICE RANDOMLY\n");
                Console.WriteLine("2-)GAME MODE 2: THROW DICE YOURSELF\n");
                Console.WriteLine("3-)SHOW HIGH SCORE LIST\n");
                Console.WriteLine("4-)GAME MODE 4: EXIT\n");

                do  /* Wrong Choice Loop For Choice */
                {
                    choice = Console.ReadLine();
                    Console.WriteLine("Please enter a number between 1 and 4");
                    if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                    {
                        a = false;
                    }
                } while (a);

                Console.Clear();

                switch (choice)
                {
                    case "1": /* Generating Number For Dice */
                        Console.WriteLine("Generated four numbers for dice randomly.");
                        dice1 = random.Next(1, 7);
                        dice2 = random.Next(1, 7);
                        dice3 = random.Next(1, 7);
                        dice4 = random.Next(1, 7);
                        Console.WriteLine("Dice A : " + dice1);
                        Console.WriteLine("Dice B : " + dice2);
                        Console.WriteLine("Dice C : " + dice3);
                        Console.WriteLine("Dice D : " + dice4);
                        break;

                    case "2":  /* Entering Number For Dice */
                        Console.WriteLine("Please enter four numbers for dices :");

                        do
                        {
                            Console.Write("Dice A: ");
                            dice1 = Convert.ToInt32(Console.ReadLine());
                            if (1 > dice1 || dice1 > 6)
                            {
                                Console.WriteLine("Please enter a number between 1 and 6");
                            }
                        } while (1 > dice1 || dice1 > 6);
                        do
                        {
                            Console.Write("Dice B: ");
                            dice2 = Convert.ToInt32(Console.ReadLine());
                            if (1 > dice2 || dice2 > 6)
                            {
                                Console.WriteLine("Please enter a number between 1 and 6");
                            }
                        } while (1 > dice2 || dice2 > 6);
                        do
                        {
                            Console.Write("Dice C: ");
                            dice3 = Convert.ToInt32(Console.ReadLine());
                            if (1 > dice3 || dice3 > 6)
                            {
                                Console.WriteLine("Please enter a number between 1 and 6");
                            }
                        } while (1 > dice3 || dice3 > 6);
                        do
                        {
                            Console.Write("Dice D: ");
                            dice4 = Convert.ToInt32(Console.ReadLine());
                            if (1 > dice4 || dice4 > 6)
                            {
                                Console.WriteLine("Please enter a number between 1 and 6");
                            }
                        } while (1 > dice4 || dice4 > 6);
                        break;

                    case "3":  /* High Score List */
                        Console.WriteLine("NAME  SURNAME  SCORE");
                        if (point1 >= point2)
                        {
                            Console.WriteLine(name1 + " " + point1);
                            Console.WriteLine(name2 + " " + point2);
                            Console.WriteLine(name + " " + point);
                        }
                        else
                        {
                            Console.WriteLine(name2 + " " + point2);
                            Console.WriteLine(name1 + " " + point1);
                            Console.WriteLine(name + " " + point);
                        }
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case "4": /* Exit */
                        Console.WriteLine("Thanks For Playing ...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
                /* RULES */

                if ((dice1 == dice2) && (dice2 == dice3) && (dice3 == dice4))
                {
                    point += 300;
                    getpoints += "1,";
                }
                else if (((dice1 == dice2) && (dice2 == dice3)) || ((dice1 == dice3) && (dice3 == dice4)) || ((dice1 == dice2) && (dice2 == dice4)) || ((dice2 == dice3) && (dice3 == dice4)))
                {
                    point += 16;
                    getpoints += "2,";
                }
                else if (((dice1 == dice2) && (dice3 == dice4)) || ((dice1 == dice3) && (dice2 == dice4)) || ((dice1 == dice4) && (dice2 == dice3)))
                {
                    point += 20;
                    getpoints += "3,";
                }
                else if ((dice1 == dice2) || (dice1 == dice3) || (dice1 == dice4) || (dice2 == dice3) || (dice2 == dice4) || (dice3 == dice4))
                {
                    point += 3;
                    getpoints += "4,";
                }
                else if ((dice1 != dice2) && (dice1 != dice3) && (dice1 != dice4) && (dice2 != dice3) && (dice2 != dice4) && (dice3 != dice4))
                {
                    point += 5;
                    getpoints += "5,";
                }
                if (((dice1 % 2 == 0) && (dice2 % 2 == 0) && (dice3 % 2 == 0) && (dice4 % 2 == 0)) || ((dice1 % 2 == 1) && (dice2 % 2 == 1) && (dice3 % 2 == 1) && (dice4 % 2 == 1)))
                {
                    point += 12;
                    getpoints += " 6,";
                }
                if (11 < (dice1 + dice2 + dice3 + dice4) && (dice1 + dice2 + dice3 + dice4) < 17)
                {
                    point += 2;
                    getpoints += " 7.";
                }
                else if ((7 < (dice1 + dice2 + dice3 + dice4) && (dice1 + dice2 + dice3 + dice4) < 12) || (16 < (dice1 + dice2 + dice3 + dice4) && (dice1 + dice2 + dice3 + dice4) < 21))
                {
                    point += 4;
                    getpoints += " 8.";
                }
                else if ((3 < (dice1 + dice2 + dice3 + dice4) && (dice1 + dice2 + dice3 + dice4) < 8) || (20 < (dice1 + dice2 + dice3 + dice4) && (dice1 + dice2 + dice3 + dice4) < 25))
                {
                    point += 30;
                    getpoints += " 9.";
                }

                /* FİNAL SCREEN */
                Console.WriteLine("You get point from the rules: " + getpoints);
                Console.WriteLine("Total score is " + point + " !!");

                /* FİNAL SCORE LİST */
                Console.WriteLine("NAME   SURNAME   SCORE");
                if (point >= point1 && point1 >= point2)
                {
                    Console.WriteLine(name + " " + point);
                    Console.WriteLine(name1 + " " + point1);
                    Console.WriteLine(name2 + " " + point2);
                }
                else if (point >= point2 && point2 >= point1)
                {
                    Console.WriteLine(name + " " + point);
                    Console.WriteLine(name2 + " " + point2);
                    Console.WriteLine(name1 + " " + point1);
                }
                else if (point <= point1 && point >= point2)
                {
                    Console.WriteLine(name1 + " " + point1);
                    Console.WriteLine(name + " " + point);
                    Console.WriteLine(name2 + " " + point2);
                }
                else if (point <= point2 && point >= point1)
                {
                    Console.WriteLine(name2 + " " + point2);
                    Console.WriteLine(name + " " + point);
                    Console.WriteLine(name1 + " " + point1);
                }
                else if (point1 >= point2 && point2 >= point)
                {
                    Console.WriteLine(name1 + " " + point1);
                    Console.WriteLine(name2 + " " + point2);
                    Console.WriteLine(name + " " + point);
                }
                else
                {
                    Console.WriteLine(name2 + " " + point2);
                    Console.WriteLine(name1 + " " + point1);
                    Console.WriteLine(name + " " + point);
                }
                Console.WriteLine("\nPress any button to play again or press 4 to exit....");
                choice =Console.ReadLine();
                Console.Clear();
            } while (choice != "4");
        }
    }
}
