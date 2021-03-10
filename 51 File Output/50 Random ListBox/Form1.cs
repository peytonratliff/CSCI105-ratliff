using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            // Now that numbers have been generated ENABLE the "Save to File" button
            saveFile.Enabled = true;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            // Add the "using System.IO;" library at the top of the program.

            // Create an instance of the StreamWriter class so we can output to a file.
            StreamWriter outputFile;

            // Actually CREATE the file on the system...in this case we are creating a Text file.
            //   In other words, a file that stores the numbers in thier ASCII representation...not numerically.

            // Notice the @ in front of the string "", this tells the complier to read the string literally and
            //   don't try to interpret the \ as another meaning.

            // In short this will create a text file called numbers.txt on the C: drive in the temp location.
            outputFile = File.CreateText(@"c:\temp\numbers.txt");

            // Use the built in property of the ListBox to get how many Items are in the object at the moment.
            for (int i = 0; i < numberListBox.Items.Count; i++)
            {
                outputFile.WriteLine(numberListBox.Items[i]);
            }
            
            // Close the file so that all information is saved.
            outputFile.Close();

            // Let the user know the file save worked.
            MessageBox.Show("Numbers have been saved!");
        }
    }
}
