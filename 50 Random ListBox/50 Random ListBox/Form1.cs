using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_Random_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genNumbers_Click(object sender, EventArgs e)
        {
            // Create a instance of the Random class
            Random randomNumber = new Random();
            int tempNumber;

            // Generate 5000 numbers and store them in the ListBox
            for (int i = 1; i <= 5000; i++)
            {
                // Generate a random number between 1 and 1,000,000
                tempNumber = randomNumber.Next(1000000);

                // Add the number to the "Items" in the ListBox (numberListBox)
                numberListBox.Items.Add(tempNumber);
            }
        }
    }
}
