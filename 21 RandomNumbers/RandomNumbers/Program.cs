using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
   class Program
   {
      static int GetRandomNumber()
      {
         Random randomNumber = new Random();
         return randomNumber.Next(-10, 10);
      }

      static void PrintNumberFacts(int theNumber)
      {
         if (theNumber > 0)
         {
            Console.WriteLine("The number is greater than zero.");
         }
         else
         {
            Console.WriteLine("The number is less than zero.");
         }


         if (theNumber > 0)
         {
            Console.WriteLine("The number is positive.");
         }
         else
         {
            if (theNumber == 0)
            {
               Console.WriteLine("The number equals zero.");
            }
            else
            {
               Console.WriteLine("The number is negative.");
            }
         }
      }

      static bool AskToRunAgain()
      {
         string userInput;

         Console.Write("Do you want to run again? (Y/N) ");
         userInput = Console.ReadLine();

         if (userInput.ToUpper() == "Y") return true;
         else return false;
      }

      static void Main(string[] args)
      {
         int someNumber;
         bool runAgain = true;

         while (runAgain)
         {
            someNumber = GetRandomNumber();
            Console.WriteLine(someNumber);

            PrintNumberFacts(someNumber);

            runAgain = AskToRunAgain();
         }
      }
   }
}
