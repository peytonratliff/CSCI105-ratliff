using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_PassingData
{
   public class Player
   {
      // Properties
      public string FullName { get; set; } 
      public string Race { get; set; }
      public string Occupation { get; set; }
      public int Strength { get; set; }
      public int Integrity { get; set; }

      // Constructor
      public Player() { }

      // Methods
      public string SummaryData()
      {
         string summaryLine = "Name: " + FullName + "\r\n";
         summaryLine += "Race: " + Race + "\r\n";
         summaryLine += "Occupation: " + Occupation + "\r\n";
         summaryLine += "Strength: " + Strength + "  Integrity: " + Integrity;

         return summaryLine;
      }
   }
}
