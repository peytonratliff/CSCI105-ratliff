using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadClass
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadEquation myEquation = new QuadEquation();

            myEquation.TermA = 2;
            myEquation.TermB = 4;
            myEquation.TermC = -8;

            Console.WriteLine(myEquation.PrintFormula());
            Console.WriteLine();
            Console.WriteLine("X\u2081 = {0:F3}", myEquation.CalcXSub());
            Console.WriteLine("X\u2082 = {0:F3}", myEquation.CalcXAdd());

            Equation equationTwo = new Equation();

            equationTwo.TermA = 1;
            equationTwo.TermB = -1;
            equationTwo.TermC = 1;

            Console.WriteLine(equationTwo.PrintFormula());
            Console.WriteLine();
            Console.WriteLine("X\u2081 = {0:F3}", equationTwo.CalcXSub());
            Console.WriteLine("X\u2082 = {0:F3}", equationTwo.CalcXAdd());

            Equation equationThree = new Equation(23, -78, 23);
            Console.WriteLine(equationThree.PrintFormula());
        }
    }
}