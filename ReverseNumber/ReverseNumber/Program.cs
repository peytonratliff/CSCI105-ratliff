using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programmer: Peyton Ratliff
//Purpose: To demostrate knowledge of while, if/else, and error checking in C#
//Date: 2 November 2018

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //This boolean controls whether the program runs again, set to true by default until the end of the program
            bool runAgain = true;
            while (runAgain)
            {
                //Setting up most of the major strings
                string numberString;
                int number = 0;
                int percent10;
                int div10;
                int revNum = 0;
                int originalNumber = 0;

                Console.Write("Enter a whole number between 1 and 999,999,999 to have it reversed: ");

                //The user enters a number and it is checked for validity. If the input is invalid then it asks for a new number
                bool badData = true;
                while (badData)
                {
                    try
                    {
                        numberString = Console.ReadLine();
                        number = Convert.ToInt32(numberString);
                        if (number > 999999999 || number < 1)
                        {
                            Console.WriteLine("That number was too big, please try again");

                        }
                        else
                        {
                            badData = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That was an invalid number, please try again");
                    }
                }

                //The number is reversed here
                while (number != 0)
                {
                    percent10 = number % 10;
                    div10 = number / 10;
                    number = div10;
                    revNum = revNum + percent10;
                    if (div10 != 0)
                    {
                        revNum = revNum * 10;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Your reversed number is: " + revNum);


                //The user is aksed if they want to continue here
                Console.WriteLine();
                Console.Write("Do you want to keep running? (Y/N): ");
                string userData = Console.ReadLine();
                userData = userData.ToLower();

                if (userData != "y")
                {
                    runAgain = false;
                }
            }
        }
    }
}