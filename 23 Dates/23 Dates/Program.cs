using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Dates
{
   class Program
   {
      static void CreateSomeDates()
      {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("CreateSomeDates Method:\n");
         Console.ForegroundColor = ConsoleColor.Gray;

         // Create a DateTime stamp variable with a date
         DateTime dateOfBirth = new DateTime(1967, 3, 30, 11, 25, 23);
         Console.WriteLine(dateOfBirth);

         // Create a DateTime stamp from a string
         string date = "5/4/1985 2:32:13 PM";
         DateTime gradDate;
         gradDate = DateTime.Parse(date);
         Console.WriteLine(gradDate);
      }

      static void PrintDateParts(DateTime dateInfo)
      {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("\nPrintDateParts Method:\n");
         Console.ForegroundColor = ConsoleColor.Gray;

         Console.WriteLine("Current Date: {0}", dateInfo);
         Console.WriteLine("          Day: {0}", dateInfo.Day);
         Console.WriteLine("        Month: {0}", dateInfo.Month);
         Console.WriteLine("         Year: {0}", dateInfo.Year);
         Console.WriteLine("         Hour: {0}", dateInfo.Hour);
         Console.WriteLine("       Minute: {0}", dateInfo.Minute);
         Console.WriteLine("       Second: {0}", dateInfo.Second);
         Console.WriteLine("  Millisecond: {0}", dateInfo.Millisecond);
         Console.WriteLine("  Day of Week: {0}", dateInfo.DayOfWeek);
         Console.WriteLine("  Day of Year: {0}", dateInfo.DayOfYear);
         Console.WriteLine("  Time of Day: {0}", dateInfo.TimeOfDay);
      }

      static void TimeWarp(DateTime currentDate)
      {
         TimeSpan periodOfTime = new TimeSpan(1, 0, 0, 0); // (days, hours, minutes, seconds)

         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("\nTimeWarp Method:\n");
         Console.ForegroundColor = ConsoleColor.Gray;

         Console.WriteLine("        Today: {0}", currentDate);
         Console.WriteLine("     Tomorrow: {0}", currentDate.Add(periodOfTime));
         Console.WriteLine("    Yesterday: {0}", currentDate.Subtract(periodOfTime));

         periodOfTime = new TimeSpan(30, 0, 0, 0);
         Console.WriteLine("A month later: {0}", currentDate.Add(periodOfTime));

      }

      static void FormatDates(DateTime current)
      {
         /*
          * Code        Pattern
          * ====        ====================
          * "d"         Short date
          * "D"         Long date
          * "f"         Full date time. Short time.
          * "F"         Full date time. Long time.
          * "g"         General date time. Short time.
          * "G"         General date time. Long time.
          * "M", 'm"    Month/day
          * "O", "o"    Round-trip date/time.
          * "R", "r"    RFC1123
          * "s"         Sortable date time.
          * "t"         Short time.
          * "T"         Long time.
          * "u"         Universal sortable date time.
          * "U"         Universal full date time.
          * "Y", "y"    Year month.
          */
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("\nFormatDates Method:\n");
         Console.ForegroundColor = ConsoleColor.Gray;

         Console.WriteLine("               Short date: " + current.ToString("d"));
         Console.WriteLine("                Long date: " + current.ToString("D"));
         Console.WriteLine("    Full date, short time: " + current.ToString("f"));
         Console.WriteLine("     Full date, long time: " + current.ToString("F"));
         Console.WriteLine(" General date, short time: " + current.ToString("g"));
         Console.WriteLine("  General date, long time: " + current.ToString("G"));
         Console.WriteLine("                Month Day: " + current.ToString("M"));
         Console.WriteLine("     Round-trip date/time: " + current.ToString("O"));
         Console.WriteLine("        RFC1123 date/time: " + current.ToString("R"));
         Console.WriteLine("       Sortable date time: " + current.ToString("s"));
         Console.WriteLine("               Short time: " + current.ToString("t"));
         Console.WriteLine("                Long time: " + current.ToString("T"));
         Console.WriteLine("Universal short date time: " + current.ToString("u"));
         Console.WriteLine(" Universal long date time: " + current.ToString("U"));
         Console.WriteLine("               Year month: " + current.ToString("Y"));
      }

      static void DisplayDateInfo(DateTime date2Process)
      {
         Console.WriteLine();
         Console.WriteLine("Date: {0}", date2Process.ToString("u"));
         Console.WriteLine("   Day Light Savings Time: " + date2Process.IsDaylightSavingTime());
         Console.WriteLine("                Leap Year: " + DateTime.IsLeapYear(date2Process.Year));
      }

      static void DateIsMethods()
      {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("\nDateIsMethods Method:\n");
         Console.ForegroundColor = ConsoleColor.Gray;

         DateTime dateInfo = DateTime.Now;
         DisplayDateInfo(dateInfo);

         dateInfo = new DateTime(2020, 2, 29, 10, 32, 12);
         DisplayDateInfo(dateInfo);

         dateInfo = new DateTime(2020, 8, 29, 10, 32, 12);
         DisplayDateInfo(dateInfo);
      }

      static void Main(string[] args)
      {
         CreateSomeDates();
         PrintDateParts(DateTime.Now);
         TimeWarp(DateTime.Now);
         FormatDates(DateTime.Now);
         DateIsMethods();
      }
   }
}
