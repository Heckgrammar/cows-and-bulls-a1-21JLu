using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_Cows_and_Bulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool invalid = true;
            int num = 0;
            int cows = 0;
            int bulls = 0;
            int attempts = 0;
                while (invalid == true)
                {
                    num = rnd.Next(1023, 9877);
                    string num1 = Convert.ToString(num);
                    int i = 0;
                    if ((num1[i] == num1[i + 1]) || (num1[i] == num1[i + 2]) || (num1[i] == num1[i + 3]))
                    { }
                    else if ((num1[i + 1] == num1[i + 2]) || (num1[i + 1] == num1[i + 3]))
                    { }
                    else
                    {
                        invalid = false;
                    }
                }
                Console.WriteLine("Enter a 4 digit number with no repeating digits.");
                Console.WriteLine();
            
            while (bulls != 4)
            {
                bool inval = true;
                while (inval != false)
                {
                    int inputINT = Convert.ToInt32(Console.ReadLine());
                    string inputSTR = Convert.ToString(inputINT);
                    if (inputINT < 1000)
                    {
                        Console.WriteLine("Number must be 4 digits (cannot start with 0)");
                    }
                    for (int i = 0; i <= inputSTR.Length - 4; i++)
                    {
                        if ((inputSTR[i] == inputSTR[i + 1]) || (inputSTR[i] == inputSTR[i + 2]) || (inputSTR[i] == inputSTR[i + 3]))
                        {
                            Console.WriteLine("Invalid Guess, Duplicate digits.");
                            Console.WriteLine("Enter another Guess.");
                            inval = true;
                        }
                        else if ((inputSTR[i + 1] == inputSTR[i + 2]) || (inputSTR[i + 1] == inputSTR[i + 3]))
                        {
                            Console.WriteLine("Invalid guess, Duplicate digits.");
                            Console.WriteLine("Enter another Guess.");
                            inval = true;
                        }
                        else if ((inputSTR[i + 2] == inputSTR[i + 3]))
                        {
                            Console.WriteLine("Invalid guess, Duplicate digits.");
                            Console.WriteLine("Enter another Guess.");
                            inval = true;
                        }
                        else
                        {
                            inval = false;
                            break;
                        }
                    }
                }
                string input = Console.ReadLine();
                int one1 = input[0];
                int two1 = input[1];
                int three1 = input[2];
                int four1 = input[3];
                string num2 = Convert.ToString(num);
                int one = num2[0];
                int two = num2[1];
                int three = num2[2];
                int four = num2[3];
                cows = 0;
                bulls = 0;
                //CHECKS BULLS
                if (one == one1)
                {
                    bulls = bulls + 1;
                }
                if (two == two1)
                {
                    bulls = bulls + 1;
                }
                if (three == three1)
                {
                    bulls = bulls + 1;
                }
                if (four == four1)
                {
                    bulls = bulls + 1;
                }
                //CHECKS COWS
                if (two == one1 || three == one1 || four == one1)
                {
                    cows = cows + 1;
                }
                if (one == two1 || three == two1 || four == two1)
                {
                    cows = cows + 1;
                }
                if (one == three1 || two == three1 || four == three1)
                {
                    cows = cows + 1;
                }
                if (one == four1 || two == four1 || three == four1)
                {
                    cows = cows + 1;
                }

                Console.WriteLine("Bulls: " + bulls + " Cows: " + cows);
                Console.WriteLine();
                attempts = attempts + 1;

                if (bulls == 4)
                {
                    Console.WriteLine("Well done!");
                    Console.WriteLine("You got the number in " + attempts + " attempts.");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine();
                }
                
            }
        }
    }
}

        }
    }
}
