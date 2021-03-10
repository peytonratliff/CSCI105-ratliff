using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declarations
            int itemCount;
            double volumeOfSwimmingPool = 1000;
            decimal bankInvestments;
            string firstName, middleName, lastName;
            bool isWorking;

            itemCount = 10;
            bankInvestments = 100234.89m;
            firstName = "Luke";
            middleName = "Unknown";
            lastName = "Skywalker";
            isWorking = false;

            Console.WriteLine(itemCount);
            Console.WriteLine(bankInvestments);
            Console.WriteLine(volumeOfSwimmingPool);
            Console.WriteLine(firstName);
            Console.WriteLine(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(isWorking);
        }
    }
}