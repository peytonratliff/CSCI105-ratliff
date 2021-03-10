using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossPay
{
    //Programmer: Peyton Ratliff
    //Purpose: To demonstrate method calling
    //Date 28 September 2018
    class Program
    {

        static double GetPayRate()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                Console.Write("Enter your pay rate: ");
                userInput = Console.ReadLine();

                //Catches exceptions in the user input
                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid number, please try again");
                }
            }
            return userNumber;
        }

        static double GetHoursWorked()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                Console.Write("Enter your hours worked: ");
                userInput = Console.ReadLine();

                //Catches exceptions in the user input
                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid number, please try again");
                }
            }
            return userNumber;
        }

        static double GetOvertimeHours()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                Console.Write("Enter your overtime hours: ");
                userInput = Console.ReadLine();

                //Catches exceptions in the user input
                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid number, please try again");
                }
            }
            return userNumber;
        }

        static void Main(string[] args)
        {
            //Establishes variables
            double totalPay = 0;
            double payRate = 0;
            double hoursWorked = 0;
            double overtimeHours = 0;
            bool runAgain = true;

            while (runAgain)
            {
                //Calls the methods
                payRate = GetPayRate();
                hoursWorked = GetHoursWorked();
                overtimeHours = GetOvertimeHours();

                totalPay = (hoursWorked * payRate) + (overtimeHours * (payRate * 1.5));
                Console.WriteLine("You earned ${0} this week!", totalPay);

                Console.Write("Would you like to run this program again? (Y/N)");
                string userInput = Console.ReadLine();
                userInput = userInput.ToUpper();

                //Determines if the user wants to run again
                if (userInput == "N")
                {
                    runAgain = false;
                }
            }
        }
    }
}
