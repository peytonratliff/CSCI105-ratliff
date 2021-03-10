using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programmer: Peyton Ratliff
//Date: 2 October 2018
//Version History:
//  1.0  10/2/2018  Basic functionality
//  2.0  10/2/2018  Detect imaginary numbers
//Purpose: To solve the quadratic formula

namespace SolveQuad
{
    class Program
    {
        static double GetTerm(string whichTerm)
        {
            string userInput;
            double termValue = 0;
            bool BadData = true;

            while (BadData)
            {
                Console.Write("Enter the value for the {0} term; ", whichTerm);
                userInput = Console.ReadLine();
                if (double.TryParse(userInput, out termValue))
                {
                    BadData = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n<ERROR> Invalid data. Try again.\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            return termValue;
        }

        static void CalcQuadSolution(double aTerm, double bTerm, double cTerm, ref string sol1, ref string sol2)
        {
            double discriminant = 0;
            double twoTermA = 0;
            double xSol1 = 0;
            double xSol2 = 0;

            discriminant = Math.Pow(bTerm, 2) - 4 * aTerm * cTerm;
            twoTermA = 2 * aTerm;

            if (discriminant >= 0) // Real solutions; non imaginary
            {
                xSol1 = (-bTerm + Math.Sqrt(discriminant)) / twoTermA;
                xSol1 = (-bTerm - Math.Sqrt(discriminant)) / twoTermA;

                sol1 = xSol1.ToString("F3");
                sol2 = xSol2.ToString("F3");
            }
            else // Imaginary solutions
            {
                discriminant = Math.Abs(discriminant);

                sol1 = (-bTerm / twoTermA).ToString("F3") + " + " + (Math.Sqrt(discriminant) / twoTermA).ToString("F3") + "i";
                sol2 = (-bTerm / twoTermA).ToString("F3") + " - " + (Math.Sqrt(discriminant) / twoTermA).ToString("F3") + "i";
            }
         }

        static string PrintFormula (double valA, double valB, double valC)
        {
            string formula;

            //Construct Term A for the formula
            if (Math.Abs(valA) == 1)
            {
                if (valA == -1)
                {
                    formula = "-x\u00B2 ";
                }
                else
                {
                    formula = "x\u00B2";
                }
            }
            else
            {
                formula = valA + "x\u00B2 ";
            }

            //Construct Term B for the formula
            if (Math.Abs(valB) == 1)
            {
                if (valB == -1)
                {
                    formula = formula + "- x ";
                }
                else
                {
                    formula = formula + "+ x ";
                }
            }
            else
            {
                if (valB < 0)
                {
                    formula += "- " + Math.Abs(valB) + "x "; //formula += is equal to formula = formula +
                }
                else
                {
                    formula += "+ " + valB + "x ";
                }
            }

            //Construct Term C for the formula
            if (valC > 0)
            {
                formula = formula + "+ " + valC;
            }
            else
            {
                formula = formula + "- " + Math.Abs(valC);
            }

            return formula;

        }


        static void Main(string[] args)
        {
            double termA = 0;
            double termB = 0;
            double termC = 0;
            string xSol1 = "";
            string xSol2 = "";

            termA = GetTerm("A");
            termB = GetTerm("B");
            termC = GetTerm("C");

            CalcQuadSolution(termA, termB, termC, ref xSol1, ref xSol2);



            Console.WriteLine();
            Console.WriteLine("Quadratic Formula Solutions:");
            Console.WriteLine();
            Console.WriteLine(PrintFormula(termA, termB, termC));


            Console.WriteLine("\nSolutions: \n X1 = {0:N3} X2 = {1:N3}", xSol1, xSol2);

            Console.Write("Hit any key to continue...");
            Console.ReadKey();
        }
    }
}
