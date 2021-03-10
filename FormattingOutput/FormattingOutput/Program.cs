using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.1415927;

            //Console.WriteLine(Pi);

            //Formatted output (String formatting)

            Console.WriteLine("The byte data type has a minimum value of {0} and a maximum value of {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Pi equals {0}. Pi times 2 equals {1}. Pi plus 1 equals {2}.", Pi, Pi * 2, Pi + 1);

            //String interpolation
            Console.WriteLine($"The int data type has a minimum value of {int.MinValue} and a maximum value of {int.MaxValue}");

            //Sting concatenation
            Console.WriteLine("Doube data type: Min value is " + double.MinValue + " Max value is " + double.MaxValue);
        }
    }
}
