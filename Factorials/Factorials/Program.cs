using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {

        static double GetNumber()
        {
            string userData;
            double userNumber = 0;
            bool badData = true;
            
            while (badData)
            {
                Console.Write("Enter a number: ");
                userData = Console.ReadLine();

                try
                {
                    userNumber = Convert.ToDouble(userData);
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That is not a valid number, please try again");
                }
            }

            return userNumber;
        }

        static void Main(string[] args)
        {
            double number = 0;
            double factorial = 1;

            number = GetNumber();

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("The factorial of {0} is {1}", number, factorial);
        }
    }
}