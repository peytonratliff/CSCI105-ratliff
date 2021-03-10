using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
   class Program
   {
      static void Main(string[] args)
      {
         string inputLine = "The quick brown fox jumped over the lazy dog.";
         string outputLine = "";

         Console.WriteLine(inputLine);
         Console.WriteLine(inputLine.ToUpper());
         Console.WriteLine(inputLine.ToLower());
         Console.WriteLine(inputLine.Count());
         Console.WriteLine(inputLine.Contains("fox"));
         Console.WriteLine(inputLine.Contains("squirrel"));
         Console.WriteLine(inputLine.IndexOf("q"));

         int i;
         int lineCount = inputLine.Count();

         for (i = 0; i < lineCount; i++)
         {
            if (i % 2 == 0)
            {
               outputLine += inputLine.Substring(i, 1).ToUpper();
            }
            else
            {
               outputLine += inputLine.Substring(i, 1).ToLower();
            }
         }
         Console.WriteLine(outputLine);

         outputLine = "";
         for (i = lineCount; i > 0; i--)
         {
            outputLine += inputLine.Substring(i - 1, 1);
         }
         Console.WriteLine(outputLine);

         Console.ReadKey();
      }
   }
}
