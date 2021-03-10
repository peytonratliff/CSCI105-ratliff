using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _00_Programming_Review
{
   class Program
   {
      /*
       * Programmer: Rick Miller
       * Purpose: This program covers various programming topics to assess student knowledge to establish a starting point.
       * 
       * Date: 9-4-2018
       * 
       * Useful Key Combinations:
       * 
       *    CTRL-F5     Run Console program and pause after program termination
       *    CTRL-K-D    Format indentations of code
       *    CTRL-K-C    Mass comment code
       *    CTRL-K-U    Mass uncomment code
       *    CTRL-N-TAB  Switch between open windows in Visual Studio
       *    CTRL-E-V    Duplicates current line
       *    
       */

      static void printHeader(string header)
      {
         /*
          * Purpose: Print a header to the screen for each section
          */

         // Print the "header" passed to the method
         Console.WriteLine();
         Console.WriteLine(header);

         // Print 25 '=' symbols to the screen
         for (int i = 0; i < 25; i++)
         {
            Console.Write("=");
         }

         // Print two blank lines
         Console.WriteLine();
         Console.WriteLine();
      }

      static void section1()
      {
         printHeader("Section 1: Output to the Screen");

         // Print several output lines to the screen
         Console.WriteLine("Hello everyone!");
         Console.WriteLine("I say it again hello!");
         Console.WriteLine("Isn't this fun!");

         // Illustrate the difference between a Write and a WriteLine
         Console.Write("I want to try something ");
         Console.WriteLine("different.");

         // Illustrate how to print special characters such as " to the screen.
         //   Need to use the \ symbol or escape sequence to tell the compiler that
         //   a special character such as " needs to be printed.
         Console.WriteLine("Now, how about something really 'different'.");
         Console.WriteLine("Or maybe this \"trick\".");
      }

      static void section2()
      {
         printHeader("Section 2: Comments");

         // This is a single line comment
         Console.WriteLine("Something worth commenting.");

         /*
          * This is a block of comments
          * Because somethings a single line is not enough
          */
         Console.WriteLine("more to comment...");
      }

      static void section3()
      {
         printHeader("Section 3: Working with Variables");

         var partNumber = 1;              // var - generic data type letting the compiler figure it out.
         byte smallValue = 23;            // byte - whole numbers (0 - 255)               ( 8 bits)
         int itemCount = 10;              // int - whole numbers (0, 1, 3, 15, -189)      (16 bits)
         double totalPrice = 20.95f;      // double - real numbers (-12.39, 13, 103.48)   (32 bits)
         decimal investment = 103234.3m;  // decimal - monetary numbers (12.333, -1.3253) (64 bits)
         char character = 'A';            // char - single Unicode value of a letter
         string firstName = "Rick";       // string - alpha numeric data
         bool isWorking = false;          // bool - Boolean or true/false variables

         Console.WriteLine(partNumber);
         Console.WriteLine(smallValue);
         Console.WriteLine(itemCount);
         Console.WriteLine(totalPrice);
         Console.WriteLine(investment);
         Console.WriteLine(character);
         Console.WriteLine(firstName);
         Console.WriteLine(isWorking);
      }

      static void section4()
      {
         printHeader("Section 4: Overflowing");

         /*
          * Overflowing is a unique situation where a mathematical operation was performed to
          * a number in memory but the result is bigger than the current data type can hold.
          * The result is an invalid result.
          * 
          * In this example, a byte data type is only 8 bits in memory.  This allows storing
          * data from 0 to 255.   A value of 255 is stored in the variable and then one added to it.
          * Logically the new value should be 256; however, 256 requires 9 bits to properly represent
          * the value.  Since a byte only has 8 bits, the result is that 0 is stored in the variable
          * which is invalid.
          *    
          *     Decimal    Binary      bitFlag Variable
          *     ==================     +-+-+-+-+-+-+-+-+
          *       255     11111111     |1|1|1|1|1|1|1|1|
          *                            +-+-+-+-+-+-+-+-+
          *                             0 1 2 3 4 5 6 7  Position in memory
          *                            +-+-+-+-+-+-+-+-+ 
          *       256    100000000   1 |0|0|0|0|0|0|0|0|
          *                          ^ +-+-+-+-+-+-+-+-+
          *                          |  
          *                          --- This can't be stored in the byte data type (9th bit) so it is lost.
          *                          
          */
         // checked
         {
            byte bitFlags = 255;
            bitFlags = (byte)(bitFlags + 1);

            Console.WriteLine("Current value: {0}", bitFlags);
         }
      }

      static void section5()
      { // LEVEL 1: START

         /*
          * Variables are only defined within the "scope" of the area they are declared in.
          * 
          * In this example the {} brackets define three different levels or areas with in the program.
          * Each area is denoted with a Level start and end indicator.
          * 
          */

         printHeader("Section 5: Variable Scope");

         int numberLevel1 = 10;

         // numberLevel1 available inside LEVEL 1

         { // LEVEL 2: START

            int numberLevel2 = 20;

            // numberLevel1 & numberLevel2 available inside LEVEL 2

            { // LEVEL 3: START

               int numberLevel3 = 30;
                    
               // numberLevel1, numberLevel2 & numberLevel3 available inside LEVEL 3

               Console.WriteLine(numberLevel3);

            } // LEVEL 3: END

            Console.WriteLine(numberLevel2);

         } // LEVEL 2: END

         Console.WriteLine(numberLevel1);
      } // LEVEL 1: END

      static void section6()
      {
         printHeader("Section 6: Formatting Output");

         const double Pi = 3.1415927;

         Console.Write("Pi: ");
         Console.WriteLine(Pi);
         Console.WriteLine();

         // Formatted Output
         Console.WriteLine("   byte - Min: {0} Max: {1}", byte.MinValue, byte.MaxValue);
         Console.WriteLine("   int  - Min: {0}    Max: {1}", int.MinValue, int.MaxValue);

         // String Interpolation
         Console.WriteLine($" double - Min: {double.MinValue}    Max: {double.MaxValue}");

         // String Concatentation
         Console.WriteLine("decimal - Min: " + decimal.MinValue + "   Max: " + decimal.MaxValue);
      }

      static void section7()
      {
         printHeader("Section 7: Creating a Table");

         // Declare variables
         int number1, number2, number3;
         string student1, student2, student3;

         // Assign values to the variables
         number1 = 97;
         number2 = 83;
         number3 = 81;

         student1 = "Tom";
         student2 = "Carrie";
         student3 = "Carol Ann";

         // Print the "title" for the table
         Console.WriteLine("Grade Table:");
         Console.WriteLine();

         /* 
          * Print the table to the screen using the following symbols
          * 
          *    +  represents a corner of the table
          *    -  represents a horizontal line in the table
          *    |  represents a vertical line in the table
          *    
          *    \t is an escape sequence to insert a TAB onto the screen
          *    
          */
         Console.WriteLine("+---------------+----+");
         Console.WriteLine("| {0} \t\t| {1} |", student1, number1);
         Console.WriteLine("| {0} \t| {1} |", student2, number2);
         Console.WriteLine("| {0} \t| {1} |", student3, number3);
         Console.WriteLine("+---------------+----+");
      }

      static void section8()
      {
         printHeader("Section 8: Type Conversion");

         // Implicit type conversion

         int wholeNumber;
         double realnumber;

         wholeNumber = 12;               // 2 bytes  (16 bits)
         realnumber = wholeNumber;       // 4 bytes  (32 bits)

         wholeNumber = (int)realnumber;    // Error occurs because data CAN NOT be converted automatically

         // Format output using concatenation numeric values are implicitily converted to strings
         Console.WriteLine(wholeNumber + "  " + realnumber);

         // Explicit type conversion
         byte smallNumber;
         int biggerNumber = 200;

         // Casting 
         smallNumber = (byte)biggerNumber;
         Console.WriteLine("byte: {0}  int: {1}", smallNumber, biggerNumber);

         biggerNumber = 300;                 // Number too big to fit in byte variable
         smallNumber = (byte)biggerNumber;   // Conversion happens and data is lost.
         Console.WriteLine("byte: {0}  int: {1}", smallNumber, biggerNumber);

         // Non-compatible Types

         string strNumber;
         // strNumber = "1234.34A";
         strNumber = "1234.34";
         double number;

         number = double.Parse(strNumber);
         number = Convert.ToDouble(strNumber);
      }

      static void section9()
      {
         printHeader("Section 9: Exception Handling");

         /*
          * Exceptions are run-time errors that occur from data anomolies or user error.
          * They result in the "crashing" because the programmer didn't code for them.  There
          * are various ways to code for exceptions with the C# try..catch statement being the
          * simplest.
          * 
          * In short, the program "trys" to run some code and if that code cases an exception the
          * statement "catches" the exception.  Once "caught" the programmer can code a response
          * to the error.
          * 
          * In this example, the program trys to convert a string to an integer; however, the string
          * contains the letter A which will not compute.   The code catches the exception and tells
          * the user there is an error.
          * 
          */

         string value = "1234A";
         int tinyNumber;

         try
         {
            // Any code that might cause an exception goes here.

            tinyNumber = int.Parse(value);
         }
         catch
         {
            // Only the code that deals with an exception occurring goes here.

            Console.WriteLine("Error: The string did not convert properly.");
         }
      }

      static void section10()
      {
         /*
          * Math Operators:
          * 
          *   +  Addition
          *   -  Subtraction
          *   *  Multiplication
          *   /  Division
          *   %  Modulus Division (Remainder)
          */

         printHeader("Section 10: Using Basic Math Operators ");

         // Basic Addition done "on the fly"
         int firstNumber = 23;
         int secondNumber = 10;
         Console.WriteLine(firstNumber + secondNumber);

         // Basic addition done by storing the result in a third variable
         int sum;
         sum = firstNumber + secondNumber;
         Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");

         // Demonstration of the basic math operations
         Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
         Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
         Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");

         // Modulus operations returns the remainder of the division
         Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");

         // Divsion should be done with a double data type to get the fractional componet
         Console.WriteLine();
         double realDivision;
         realDivision = (double)firstNumber / secondNumber;
         Console.WriteLine($"{firstNumber} / {secondNumber} = {realDivision}");

         // Gross pay example
         decimal payrate = 9.67m;
         int hours = 40;
         decimal overtime = 4.5m;
         decimal gross;

         Console.WriteLine();
         Console.WriteLine("Pay Calculator: ");

         // Perform the gross pay calculation
         gross = (payrate * hours) + (payrate * 1.5m * overtime);

         // Notice the use of String Formatters to control the appearance of the output
         Console.WriteLine("  Current Payrate: {0:C}", payrate);
         Console.WriteLine($"  Hours worked: {hours:N1}");
         Console.WriteLine("  Overtime worked: {0:N2}", overtime);
         Console.WriteLine("  Gross Pay: {0:C2}", gross);

         // More String Formatter examples
         double value = 2235.205;

         Console.WriteLine();
         Console.WriteLine("Formatter Examples:");
         Console.WriteLine("1) {0} \t\tNone", value);
         Console.WriteLine("2) {0:C} \t\tCurrency", value);
         Console.WriteLine("2) {0:C4} \t\tCurrency with 4 decimal points", value);
         Console.WriteLine("2) {0:N} \t\tNumeric", value);
         Console.WriteLine("2) {0:N1} \t\tNumeric with 1 decimal point", value);
         Console.WriteLine("2) {0:E} \tScientific Notation", value);

         // Increment/Decrement Operators
         int counter = 0;

         Console.WriteLine();
         Console.WriteLine("Increment/Decrement Operators: ");
         Console.WriteLine();
         Console.WriteLine("Initial: {0}", counter);
         counter++;
         Console.WriteLine("Increment: " + counter);
         counter++;
         Console.WriteLine("Increment: " + counter);
         counter--;
         Console.WriteLine($"Decrement: {counter}");

         // Prefix vs. Postfix operations
         Console.WriteLine();
         Console.WriteLine($"Increment: {counter++}");
         Console.WriteLine($"Increment: {counter}");
         Console.WriteLine($"Increment: {++counter}");
      }

      static void section11()
      {
         printHeader("Section 11: Math Equations");

         /* 
          * Formula for area of triangle: A = 1/2BH
          */

         double triBase, triHeight;
         double area;

         triBase = 3;
         triHeight = 2;
         area = 1 / 2 * triBase * triHeight;
         Console.WriteLine("ERROR: Area is {0:N4}.\n", area);

         /*
          * Error is produced by the 1/2 calculation.
          * Complier sees them as integers so it does integer division.
          * This results in the value of 0 so the answer becomes 0.
          */

         // Alternative approaches to calculate the area

         // The 1.0 causes the compiler to perform real number division
         area = 1.0 / 2 * triBase * triHeight;
         Console.WriteLine("Area is {0:N4}.\n", area);

         // The 0.5 causes real number division.
         area = 0.5 * triBase * triHeight;
         Console.WriteLine("Area is {0:N4}.\n", area);

         /* 
          * Formula for area of trapezoid: A = ((b1 + b2)/2)h
          */

         double trapB1, trapB2, height;

         trapB1 = 5;
         trapB2 = height = 3;

         // Careful use of parenthenses is important
         area = ((trapB1 + trapB2) / 2) * height;
         Console.WriteLine("Trapezoid Area is {0:N4}.\n", area);

         /* 
          * The C# MATH library has numerous useful mathematical methods that can be
          * used to perform more complex calculations.
          */

         // Using Pi and E
         Console.WriteLine("Pi without a string formatter: " + Math.PI);
         Console.WriteLine($"The value of PI is {Math.PI:N10}");
         Console.WriteLine("The value of E is {0:N10}\n", Math.E);

         /*
          * Formula for the area of circle: A = (pi)r^2
          */

         double radius = 8.3;

         // The Math.Pow function will raise any value to the specified power
         area = Math.PI * Math.Pow(radius, 2);
         Console.WriteLine("Circle Area is {0:N4}\n", area);

         /* 
          * Quadratic Formula: 
          * 
          *   x1 = -b + SQRT(b^2 - 4ac)
          *        --------------------
          *               2a
          *               
          *   x2 = -b - SQRT(b^2 - 4ac)
          *        --------------------
          *               2a
          *   
          *   Typically variables names of a, b, c are not good names.  However,
          *   because the names match the formula they make sense here.
          *   
          */

         double b, a, c, x1, x2;

         // Carefully selecting the values of a, b and c to avoid imaginary numbers.
         a = 8;
         b = 45;
         c = 3;

         /* 
          * Brute force calculation of the solutions in a single line.
          * This works but can be confusing to read.
          *
          * Notice the Math.Sqrt method to perform the square root function.
          * Notice the importance of proper placement of parentheses to control
          *     order of operations.
          */

         x1 = (-1 * b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
         x2 = (-1 * b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

         // Output the solutions on the screen
         Console.WriteLine("Brute force formula:");
         Console.WriteLine("The first value of X is {0:N6}", x1);
         Console.WriteLine("The first value of X is {0:N6}", x2);
         Console.WriteLine();

         /*
          * Alternative approach by calculating the discriminant first.  
          *   This is an advantage to this approach...do you remember?
          */

         double discriminant;

         discriminant = Math.Pow(b, 2) - 4 * a * c;

         // Formula is a bit easier to read with this approach.
         x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
         x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

         Console.WriteLine("Formula with discriminant:");
         Console.WriteLine("The first value of X is {0:N6}", x1);
         Console.WriteLine("The first value of X is {0:N6}", x2);
         Console.WriteLine();

         /*
          * Area of triangle with two sides and an angle
          */

         double sideA, sideB, angleC;

         sideA = 8.2;
         sideB = 13.4;
         angleC = 53;

         // Math library has methods for all the typical trigometric functions
         area = 0.5 * sideA * sideB * Math.Sin(angleC);
         Console.WriteLine("Area of Triangle using trig is {0:N5}", area);
      }

      static void section12()
      {
         printHeader("Section 12: User Input");

         // All user input should be read in as STRING variables
         string userName;

         // Notice the use of WRITE to keep the cursor on the same line
         Console.Write("Enter your name: ");

         // Console.ReadLine will read all the keys pressed until the ENTER key is hit.
         //   The returned string is then placed into the userName variable.
         userName = Console.ReadLine();

         Console.WriteLine();
         Console.WriteLine("Hello {0}, it is good to meet you.", userName);
      }

      static void section13()
      {
         /* The if statement is used in C# to control flow of a program.  This is 
          * how decisions are made.
          * 
          * Syntax:    if (logic condition)
          *            {
          *              code if condition is TRUE
          *            }
          * 
          * Logical Operators:
          * 
          *   ==  equals
          *   >=  greater than or equal
          *   >   greater than
          *   <=  less than or equal
          *   <   less than
          *   !=  not equal
          */

         printHeader("Section 13: Basic if Statements");

         string userInput;
         int inputValue1, inputValue2;

         /* 
          * Since we are asking the user for numeric data and plan to and
          * plan to convert them, it is a good idea to use the try..catch
          * routine.
          * 
          */

         try
         {
            // Read a numeric value from the user.
            Console.Write("Enter a number between 1 and 100: ");
            userInput = Console.ReadLine();

            // Attempt to convert to the numeric equivalent of the number read.
            inputValue1 = Convert.ToInt32(userInput);

            // Get the second number from the user.
            Console.Write("Enter a number between 1 and 100: ");

            // Notice in this example the userInput variable is not used.  Instead
            //   the commands are "nested" inside each other.
            inputValue2 = Convert.ToInt32(Console.ReadLine());

            // Output the two numbers to the screen
            Console.WriteLine("  First Number: {0} \n Second Number: {1}", inputValue1, inputValue2);

            // Are the numbers equal to each other?
            if (inputValue1 == inputValue2)
            {
               Console.WriteLine("The numbers equal each other.");
            }

            // Is the first number greater than or equal to the second number?
            if (inputValue1 >= inputValue2)
            {
               Console.WriteLine($"The first number {inputValue1} is greater than the second number {inputValue2}");
            }

            // Is the first number less than the second number?
            if (inputValue1 < inputValue2)
            {
               Console.WriteLine("The first number [{0}] is less than the second number [{1}]", inputValue1, inputValue2);
            }

            // Is the first number not equal to the second number?
            //   Notice the absence of the {}, this is legal if there is ONLY one line of code.
            if (inputValue1 != inputValue2) Console.WriteLine("{0} does not equal {1}.", inputValue1, inputValue2);
         }
         catch
         {
            // Something didn't convert so tell the user.
            Console.WriteLine("There was an error converting the numbers.");
         }
      }

      static void section14()
      {
         /*
          * The if..then..else allows the program to execute one portion of code if
          * the condition is TRUE and another portion of code if the condition is FALSE.
          * 
          * Syntax:  if (logical condition)
          *          {
          *            code if condition is TRUE
          *          }
          *          else
          *          {
          *            code if condition is FALSE
          *          }
          */
         printHeader("Section 14: if..then..else Statements");

         string userResponse;

         // Get input from the user
         Console.Write("Is the power on? (Y/N)");
         userResponse = Console.ReadLine();

         // Convert the user input to upper case
         userResponse = userResponse.ToUpper();

         // Print output to the screen based on the yes or no response.
         if (userResponse == "Y")
         {
            Console.WriteLine("Great!  At least that much is working.");
         }
         else
         {
            Console.WriteLine("Not good.  We need to get the power on first.");
         }
      }

      static void section15()
      {
         /*
          * Often in programming there are multiple conditions that could happen
          * based on the situation. The requires nesting of if statements to accomplish
          * the task.
          */
         printHeader("Section 15: Nested if Statements");

         string currentWeather;
         string userResponse;
         bool goodWeather;       // Boolean variable - TRUE or FALSE only
         double currentTemp;

         // Ask the user thier opinion of the weather.
         Console.Write("Is the weather good? (y/n)");
         currentWeather = Console.ReadLine().ToUpper();

         // Set the boolean variable goodWeather to TRUE or FALSE based on the
         //   user input.

         // NOTICE: the absense of the {} braces.
         if (currentWeather == "Y") goodWeather = true;
         else goodWeather = false;

         // Ask the user for the temperature
         Console.Write("What is temperature? ");
         userResponse = Console.ReadLine();

         // Convert the input to a numeric equivalent.

         // NOTICE: That the try..catch structure was not used!  Shame on us!
         currentTemp = double.Parse(userResponse);

         // Now the response on the screen will be based on two conditions...the 
         //   opinion of the weather and the temperature.

         // First check if the weather is good  (aka goodWeather is set to TRUE)
         if (goodWeather)
         {
            // Yeap good weather!  Now check to see if the temperature is over 80.
            if (currentTemp > 80)
            {
               Console.WriteLine("It is good weather and the temperature is greater than 80.");
            }
            else
            {
               Console.WriteLine("It is good weather and the temperature is less than or equal to 80.");
            }
         }
         else  // Bad weather since goodWeather is set to FALSE
         {
            // Yeap bad weather!  Now check to see if the temperature is over 80.
            if (currentTemp > 80)
            {
               Console.WriteLine("It is bad weather and the temperature is greater than 80.");
            }
            else
            {
               Console.WriteLine("It is bad weather and the temperature is less than or equal to 80.");
            }
         }

         // NOTICE the repeatative code in the nested if statements.  This is an indicator that 
         //   there is a better way to approach this!
      }

      static void section16()
      {
         /* 
          * Multiple Condition Operators:
          * 
          *   ||   Or
          *   &&   And
          *   
          */

         printHeader("Section 16: Multiple Condition if Statements");

         const int maxLevel = 10;
         const int maxUpgrade = 5;

         int currentLevel, currentUpgrade;

         // Get current level and convert...this should be using try..catch
         Console.Write("Enter your current LEVEL (1-10): ");
         string userInput = Console.ReadLine();
         currentLevel = Convert.ToInt32(userInput);

         // Get current UPGRADE level and convert
         //   Once again should be using try..catch, but a better approach is coming soon.
         Console.Write("Enter your current UPGRADE level (1-5):");
         userInput = Console.ReadLine();
         currentUpgrade = Convert.ToInt32(userInput);

         // Now create a nested if structure testing MULTIPLE conditions at once.
         if (currentLevel < maxLevel && currentUpgrade <= maxUpgrade)
         {
            Console.WriteLine("Continue to increase LEVELS!");
         }
         else
         {
            if (currentLevel == maxLevel && currentUpgrade < maxUpgrade)
            {
               Console.WriteLine("At max Levels, but you can UPGRADE!");
            }
            else
            {
               if (currentLevel == maxLevel && currentUpgrade == maxUpgrade)
               {
                  Console.WriteLine("You can't increase LEVELS or UPGRADE anymore.");
               }
            }
         }

         // Pause the program by using the Console.ReadKey method.  This waits until any key is hit.
         Console.WriteLine("Hit any key to contine...");
         Console.ReadKey();
      }

      static void section17()
      {
         /*
          * Programs often need to repeat the same code until a condition is meet.
          * This is a control flow topic call iteration.
          * 
          * The first iteration statement in C# is called a while loop.  This statement
          * will repeat a section of code until a the logical condition is TRUE.
          * 
          * Syntax:  while (logical condition)
          *          {
          *            code to repeat
          *          }
          *         
          * In this example, we will ask for numeric input from the user and attempt to convert.
          * If there is an error, we will tell the user and ask for the number again.  This 
          * continues until they give us good input.
          * 
          */
         printHeader("Section 17: while Loops");

         string userInput;

         // The boolean variable is the key.  We assume the data is invalid and set to TRUE.
         bool invalidData;
         double desiredPayRate = 0;

         // Clear the screen
         Console.Clear();

         // As long as invalidData is TRUE keep asking for input.

         invalidData = true;
         while (invalidData)
         {
            try
            {
               // Ask the user for input and attempt to convert.
               Console.Write("Enter your desired payrate per hour: ");
               userInput = Console.ReadLine();

               desiredPayRate = double.Parse(userInput);

               // If the program got to this line of code, the input converted.
               //   So set invalidData to false, because we now have valid data.
               invalidData = false;
            }
            catch
            {
               // ERROR the input did not convert so tell the user and try again.
               //    Why try again?  Because invalidData is still TRUE.
               Console.WriteLine();

               // Change the font color to get the user's attention
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("That was not a valid number.  Please try again.");

               // Return the font color to gray.
               Console.ForegroundColor = ConsoleColor.Gray;
            }
         }

         // Output the data to user and change the font color again.
         Console.WriteLine();
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("You said you wanted to get paid {0:C2} per hour.", desiredPayRate);

         // Make sure to put the font color back to gray.
         Console.ForegroundColor = ConsoleColor.Gray;
      }

      static void section18()
      {
         /*
          * Another iteration statement in C# is the for loop.  This will execute
          * a portion of code an exact number of times.
          * 
          * Syntax: for (loop counter; logical condition; loop increment)
          *         {
          *            code to repeat
          *         }
          *         
          */
         printHeader("Section 18: for Loops");

         Console.WriteLine("Let's count to 100!");
         Console.Write("Hit any key to get started...");
         Console.ReadKey();

         /*
          * The loop counter is a variable called i which is an integer
          *    Variable names of i, j, k, etc. are acceptable for counter variables.
          * 
          * The loop will continue to repeat as long as i < 100.
          * 
          * At the end of each "cycle", the counter i is incremented by 1.
          * 
          */
         for (int i = 1; i <= 100; i++)
         {
            Console.WriteLine("Number {0}", i);
         }

         Console.Write("Hit any key to continue...");
         Console.ReadKey();
      }

      static void section19()
      {
         /*
          * Just like if statements, loops can be nested inside of each other.
          * Typically, it is a for loop inside a for loop.
          * 
          * This example illustrates the behavior of an Odometer.  The other loop
          * counts the miles while the inner loop counts the tenths of miles.
          */
         printHeader("Section 19: Nested for loops");

         Console.WriteLine("Odometer:");

         int miles;
         int tenthsMiles;
         string displayLine;

         // Let's hid the cursor
         Console.CursorVisible = false;

         // Setup the miles loop to count upto 10 (aka 0 to 9 miles)

         for (miles = 0; miles < 10; miles++) // Outer Loop: START
         {
            // Setup the tenths loop to count up to 10 (aka 0.1 to 0.9)
            for (tenthsMiles = 0; tenthsMiles <= 9; tenthsMiles++) // Inner Loop: START
            {
               // Create a string to represent the current mileage (0.0, 0.1, 0.2, etc.)
               //   NOTICE the numeric values are implicitly converted to strings
               displayLine = miles + "." + tenthsMiles;

               // Write the mileage to the screen.
               Console.Write(displayLine);

               // A bit of programming "black magic" here.
               //   Without going into a lengthy explaination, this moves the cursor back
               //   to the beginning of the line.
               Console.SetCursorPosition(Console.CursorLeft - displayLine.Length, Console.CursorTop);

               /* More "black magic"...this basically asks the program to take a nap for 100 nanoseconds.
                * 
                * The concept of threading is an advanced programming topic for a later time.
                * 
                * Why do this?  Modern computers are so fast that without the pause on each loop
                * it would complete the work without out you getting the effect of counting on the
                * screen.
                * 
                */
               Thread.Sleep(100);
            } // Inner Loop: END
         } // Outer Loop: END

         Console.WriteLine("Destination reached...hit anykey");
         Console.ReadKey();
      }

      static void Main(string[] args)
      {
         //section1();    // Output to the Screen
         //section2();    // Comments
         //section3();    // Working with Variables
         //section4();    // Overflowing
         //section5();    // Variable Scope
         //section6();    // Formatting Output
         //section7();    // Creating a Table
         //section8();    // Type Conversion
         //section9();    // Exception Handling
         //section10();   // Using Basic Math Operators
         //section11();   // Math Equations
         //section12();   // User Input
         //section13();   // Basic if Statements
         //section14();   // if..then..else Statements
         //section15();   // Nested if statements
         //section16();   // Multiple Condition if Statements
         //section17();   // while Loops
         //section18();   // for Loops
         section19();   // Nested for Loops
      }
   }
}
