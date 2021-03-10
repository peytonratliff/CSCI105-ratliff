using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAge;
            int ageBefore;

            String userInput;
            Console.Write("Enter your current age: ");
            userInput = Console.ReadLine();
            try
            {
                currentAge = int.Parse(userInput);

                ageBefore = currentAge;
                currentAge = currentAge + 17;

                Console.WriteLine("Age calculator in 17 years");
                Console.WriteLine();
                Console.WriteLine($"          Age now: {ageBefore}");
                Console.WriteLine("  Age in 17 years: " + currentAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, there was an error");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
