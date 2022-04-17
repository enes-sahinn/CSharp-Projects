using System;

namespace Chemical_Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;  // Variable for take input from the user at the end of the program 
            do
            {
                // -----------------------Character Scan-----------------------
                string formula;
                string chars = "CcHh+=0123456789";
                bool flag = true;
                bool flag2 = true;
                int count = 0;
                do
                {
                    count = 0;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter a chemical formulation as a single string:");
                    formula = Convert.ToString(Console.ReadLine());
                    for (int i = 0; i < formula.Length; i++)
                    {
                        for (int j = 0; j < chars.Length; j++)
                        {
                            if (formula[i] == chars[j])
                                count++;
                        }
                    }
                    for (int i = 0; i < formula.Length; i++)
                    {
                        if (formula[i] == '=')
                            flag2 = false;
                    }
                    if (count == formula.Length && flag2 == false)
                        flag = false;
                    else
                    {
                        Console.WriteLine("Invalid character");
                        Console.WriteLine("(The chemical formulation can only include C, c, H, h, +, =, and digits and must include '=')");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine();
                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine();
                    }
                } while (flag);
                formula = formula.ToUpper();

                // -------------------------Variables-------------------------
                double leftsumc = 0, rightsumc = 0;
                double leftmultipc = 1, rightmultipc = 1;
                double leftsumh = 0, rightsumh = 0;
                double leftmultiph = 1, rightmultiph = 1;
                int digit;                                                           // Number value of string 

                // -----Dividing formula into arrays with using split -----           
                string[] sides = formula.Split('=');
                string[] leftside = sides[0].Split('+');
                string[] rightside = sides[1].Split('+');
                string[] leftsidecvalue = new string[2];
                string[] leftsidehvalue = new string[2];
                string[] rightsidecvalue = new string[2];
                string[] rightsidehvalue = new string[2];

                //---------Calculating the number of the 'C' and 'H'---------
                for (int i = 0; i < leftside.Length; i++)
                {
                    leftmultipc = 1;
                    for (int j = 0; j < leftside[i].Length; j++)
                    {
                        if (leftside[i][j] == 'C')
                        {
                            leftsidecvalue = leftside[i].Split('C');
                            for (int k = 0; k < leftsidecvalue.Length; k++)
                            {
                                if (leftsidecvalue[k] == "")
                                    leftsidecvalue[k] = "1";
                                digit = Convert.ToInt32(leftsidecvalue[k]);
                                leftmultipc *= digit;
                            }
                            leftsumc += leftmultipc;
                        }
                    }
                }
                for (int i = 0; i < leftside.Length; i++)
                {
                    leftmultiph = 1;
                    for (int j = 0; j < leftside[i].Length; j++)
                    {
                        if (leftside[i][j] == 'H')
                        {
                            leftsidehvalue = leftside[i].Split('H');
                            for (int k = 0; k < leftsidehvalue.Length; k++)
                            {
                                if (leftsidehvalue[k] == "")
                                    leftsidehvalue[k] = "1";
                                digit = Convert.ToInt32(leftsidehvalue[k]);
                                leftmultiph *= digit;
                            }
                            leftsumh += leftmultiph;
                        }
                    }
                }
                for (int i = 0; i < rightside.Length; i++)
                {
                    rightmultipc = 1;
                    for (int j = 0; j < rightside[i].Length; j++)
                    {
                        if (rightside[i][j] == 'C')
                        {
                            rightsidecvalue = rightside[i].Split('C');
                            for (int k = 0; k < rightsidecvalue.Length; k++)
                            {
                                if (rightsidecvalue[k] == "")
                                    rightsidecvalue[k] = "1";
                                digit = Convert.ToInt32(rightsidecvalue[k]);
                                rightmultipc *= digit;
                            }
                            rightsumc += rightmultipc;
                        }
                    }
                }
                for (int i = 0; i < rightside.Length; i++)
                {
                    rightmultiph = 1;
                    for (int j = 0; j < rightside[i].Length; j++)
                    {
                        if (rightside[i][j] == 'H')
                        {
                            rightsidehvalue = rightside[i].Split('H');
                            for (int k = 0; k < rightsidehvalue.Length; k++)
                            {
                                if (rightsidehvalue[k] == "")
                                    rightsidehvalue[k] = "1";
                                digit = Convert.ToInt32(rightsidehvalue[k]);
                                rightmultiph *= digit;
                            }
                            rightsumh += rightmultiph;
                        }
                    }
                }

                // Comparison of the values of 'C' and 'H'
                if (rightsumc == leftsumc && rightsumh == leftsumh)
                    Console.WriteLine("tantamount");
                else
                    Console.WriteLine("not tantamount");

                // --------------Writing of the values of C and H-------------- 
                Console.WriteLine(leftsumh + "H = " + rightsumh + "H");
                Console.WriteLine(leftsumc + "C = " + rightsumc + "C");

                Console.WriteLine("Press 'A' button to write again or press any button to exit.");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice == "a" || choice == "A");                            // if the user press 'A', the program start again
        }
    }
}
