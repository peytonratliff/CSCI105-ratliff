using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            double sum;
            string userData;
            bool runAgain = true;
            bool badData;

            while (runAgain)
            {
                badData = true;

                while (badData)
                {
                    try
                    {
                        Console.WriteLine("Enter the first number: ");
                        userData = Console.ReadLine();

                        number1 = Convert.ToDouble(userData);
                        badData = false;
                    }
                    catch
                    {

                    }
                }

                badData = true;

                while (badData)
                {
                    try
                    {
                        Console.WriteLine("Enter the second number: ");
                        userData = Console.ReadLine();

                        number2 = Convert.ToDouble(userData);
                        badData = false;
                    }
                    catch
                    {

                    }
                }

                sum = number1 + number2;
                Console.WriteLine("The sum is {0}", sum);


                Console.WriteLine();
                Console.Write("Do you want to keep running? (Y/N): ");
                userData = Console.ReadLine();
                userData = userData.ToLower();

                if(userData != "y")
                {
                    runAgain = false;
                }
            }


        }
    }
}
