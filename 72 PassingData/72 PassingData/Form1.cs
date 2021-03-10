using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _72_PassingData
{
   public partial class Form1 : Form
   {
      // Global variables
      public Player myPlayer = new Player();

      public Form1()
      {
         InitializeComponent();
      }

      private void fullNameTB_TextChanged(object sender, EventArgs e)
      {
         myPlayer.FullName = fullNameTB.Text;
      }

      private void raceTB_TextChanged(object sender, EventArgs e)
      {
         myPlayer.Race = raceTB.Text;
      }

      private void occupationTB_TextChanged(object sender, EventArgs e)
      {
         myPlayer.Occupation = occupationTB.Text;
      }

      private void CheckData_TextChanged(object sender, EventArgs e)
      {
         TextBox whichBox = (TextBox)sender;
         int numericValue;

         if (int.TryParse(whichBox.Text, out numericValue))
         {
            if (whichBox.Name.Contains("strength"))
            {
               myPlayer.Strength = numericValue;
            }
            else
            {
               myPlayer.Integrity = numericValue;
            }

            whichBox.BackColor = Color.LightGreen;
         }
         else
         {
            whichBox.BackColor = Color.LightCoral;
         }
      }

      private void summaryButton_Click(object sender, EventArgs e)
      {
         // Create a new instance of the SummaryForm form.
         SummaryForm summaryData = new SummaryForm();

         // Load the .Tag property with the instance of the class Player (myPlayer)
         summaryData.Tag = myPlayer;

         // Show the form on the screen
         summaryData.Show();
      }
   }
}
