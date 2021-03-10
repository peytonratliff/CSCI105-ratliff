using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declarations
            string userWeightInput;
            string userHeightInput;
            double weight;
            double height;
            double bmi;

            bool runAgain = false;

            while (runAgain)
            {
                //Title
                Console.WriteLine("BMI Calculator:");
                Console.WriteLine();


                bool badData = true;

                while (badData)
                {
                    try
                    {
                        //Getting user input
                        Console.Write("Enter your weight in pounds: ");
                        userWeightInput = Console.ReadLine();
                        Console.Write("Enter your height in inches: ");
                        userHeightInput = Console.ReadLine();

                        //Attempting to convert user input to double
                        weight = Convert.ToDouble(userWeightInput);
                        height = Convert.ToDouble(userHeightInput);
                        badData = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input");
                    }
                }


                bmi = 703 * (weight / Math.Pow(height, 2));

                Console.WriteLine("Your BMI is: {0}", bmi);

                Console.Write("Would you like to run again? (Y/N)");
                Console.ReadLine
            }



        }
    }
}