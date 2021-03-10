using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreNumbers = true;
            int counter = 0;
            string userInput;

            double userNumber = 0;
            double sum = 0;

            while (moreNumbers)
            {
                bool badData = true;
                while (badData)
                {

                    Console.Write("Enter a number: ");
                    userInput = Console.ReadLine();



                    try
                    {
                        userNumber = Convert.ToDouble(userInput);
                        badData = false;
                    }
                    catch
                    {
                        Console.WriteLine("That was not a valid number");
                    }
                }

                counter++;
                Console.WriteLine("{0} of 5: You entered {1}",counter, userNumber);
                sum = sum + userNumber;
                Console.WriteLine("Running total is {0}", sum);

                if (counter == 5)
                {
                    moreNumbers = false;
                }
            }
        }
    }
}