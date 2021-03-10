using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedure_Calls
{
    class Program
    {
        static double newNumber()
        {
            double ver1Number = 20;

            Console.WriteLine();
            Console.WriteLine("In the newNumber v1.0 method.");

            return ver1Number;
        }
        static double newNumberv2(string description)
        {
            double ver2Number = 30;

            Console.WriteLine();
            Console.WriteLine(description);

            return ver2Number;
        }
        static void newNumberv3(double currentNumber, string description)
        {
            double ver3Number;

            ver3Number = currentNumber + 10;

            Console.WriteLine();
            Console.WriteLine(description);
            Console.WriteLine("The new v3.0 number is " + ver3Number);
        }

        static void Main(string[] args)
        {
            double number = 10;

            Console.WriteLine("The original number.");
            Console.WriteLine("The number is " + number);

            number = newNumber();
            Console.WriteLine("The new number is " + number);

            number = newNumberv2("In the newNumber v2.0 method.");
            Console.WriteLine("The new v2.0 number is " + number);

            string comment = "In the newNumber v3.0 method.";

            newNumberv3(number, comment);

            newNumberv3(number, "In the newNumber v3.0 method again.");

            Console.ReadKey();

        }
    }
}
