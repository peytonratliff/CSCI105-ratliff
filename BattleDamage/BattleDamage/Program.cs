using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Programmer: Peyton Ratliff
    //Purpose: To demonstrate modluar code
    //Date: 28 September 2018
    class Program
    {

        static double GetWeaponDamage()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                jump1:
                Console.Write("Enter your weapon damage (10-500): ");
                userInput = Console.ReadLine();

                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    if (userNumber < 10 || userNumber > 500)
                    {
                        Console.WriteLine("That was not a valid input, please try again (out of scope)");
                        goto jump1; //I know this is spaghetti code, but I could figure out how to tell the program that I didn't want a number out of scope and I was running out of time.
                                    //I'll ask you about this after class and we can come back and fix it. Sorry about that.
                    }
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid input, please try again (not a number)");
                }
            }

            return userNumber;
        }

        static double GetAttackPower()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                jump2:
                Console.Write("Enter your attack power (1-10): ");
                userInput = Console.ReadLine();

                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    if (userNumber < 1 || userNumber > 10)
                    {
                        Console.WriteLine("That was not a valid input, please try again (out of scope)");
                        goto jump2;
                    }
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid input, please try again (not a number)");
                }
            }

            return userNumber;
        }

        static double GetWeaponSpeed()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                jump3:
                Console.Write("Enter your weapon speed (1.0-5.0): ");
                userInput = Console.ReadLine();

                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    if (userNumber < 1.0 || userNumber > 5.0)
                    {
                        Console.WriteLine("That was not a valid input, please try again (out of scope)");
                        goto jump3;
                    }
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid input, please try again (not a number)");
                }
            }

            return userNumber;
        }

        static double GetDamageMultiplier()
        {
            string userInput;
            double userNumber = 0;
            bool badData = true;

            while (badData)
            {
                jump4:
                Console.Write("Enter your damage multplier (1.0-4.0): ");
                userInput = Console.ReadLine();

                try
                {
                    userNumber = Convert.ToDouble(userInput);
                    if (userNumber < 1.0 || userNumber > 4.0)
                    {
                        Console.WriteLine("That was not a valid input, please try again (out of scope)");
                        goto jump4;
                    }
                    badData = false;
                }
                catch
                {
                    Console.WriteLine("That was not a valid input, please try again (not a number)");
                }
            }

            return userNumber;
        }

        static void Main(string[] args)
        {
            double battleDamage = 0;
            double weaponDamage = 0;
            double attackPower = 0;
            double weaponSpeed = 0;
            double damageMultiplier = 0;

            weaponDamage = GetWeaponDamage();
            attackPower = GetAttackPower();
            weaponSpeed = GetWeaponSpeed();
            damageMultiplier = GetDamageMultiplier();

            battleDamage = (weaponDamage + attackPower / 3.5 * weaponSpeed) * damageMultiplier;

            Console.WriteLine("Your battle damage is, {0}", battleDamage);
        }
    }
}