using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Global variables

        //This array makes a grid of variables just like the 3x3 grid the x's and o's exist on
        int[,] theGrid = new int[3, 3];

        //This variable simply flips every turn so that both x's and o's can be placed
        bool x = true;


        public Form1()
        {
            InitializeComponent();
        }

        //This method contains the bulk of the program, and is called whenever one of the grid spots is taken
        private void Changer(object sender)
        {
            //This is how the program determines which box to change
            PictureBox pb = (PictureBox)sender;

            int row;
            int col;

            //The .tag property of each picturebox contains its own coordinates
            string coordinates = (string)pb.Tag;
            row = int.Parse(coordinates.Substring(0, 1));
            col = int.Parse(coordinates.Substring(1, 1));

            if (x == true)
            {
                pb.Image = Resources.X;
                //After one of the boxes is clicked, it can't be clicked again until it is re-enabled (upon start or restart)
                pb.Enabled = false;

                //This sets the value of the variable associated to the clicked box to 200
                theGrid[row, col] = 200;


            }
            else
            {
                pb.Image = Resources.O;
                //After one of the boxes is clicked, it can't be clicked again until it is re-enabled (upon start or restart)
                pb.Enabled = false;

                //This sets the value of the variable associated to the clicked box to 2
                theGrid[row, col] = 2;
            }

            //A single integer is made that contains the value of every single winning combination. Every time a picture is checked the program adds together these
            //posibilities and determines if there has been a winner yet.
            int row1 = theGrid[0, 0] + theGrid[0, 1] + theGrid[0, 2];
            int row2 = theGrid[1, 0] + theGrid[1, 1] + theGrid[1, 2];
            int row3 = theGrid[2, 0] + theGrid[2, 1] + theGrid[2, 2];
            int col1 = theGrid[0, 0] + theGrid[1, 0] + theGrid[2, 0];
            int col2 = theGrid[0, 1] + theGrid[1, 1] + theGrid[2, 1];
            int col3 = theGrid[0, 2] + theGrid[1, 2] + theGrid[2, 2];
            int diag1 = theGrid[2, 0] + theGrid[1, 1] + theGrid[0, 2];
            int diag2 = theGrid[2, 2] + theGrid[1, 1] + theGrid[0, 0];

            if (row1 == 600 || row2 == 600 || row3 == 600 || col1 == 600 || col2 == 600 || col3 == 600 || diag1 == 600 || diag2 == 600)
            {
                MessageBox.Show("X's won!");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;

                row1 = 0;
                row2 = 0;
                row3 = 0;
                col1 = 0;
                col2 = 0;
                col3 = 0;
                diag1 = 0;
                diag2 = 0;
            }
            if (row1 == 6 || row2 == 6 || row3 == 6 || col1 == 6 || col2 == 6 || col3 == 6 || diag1 == 6 || diag2 == 6)
            {
                MessageBox.Show("O's won!");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;

                row1 = 0;
                row2 = 0;
                row3 = 0;
                col1 = 0;
                col2 = 0;
                col3 = 0;
                diag1 = 0;
                diag2 = 0;
            }

            //This flips the variable from true/false, changing the turn from x or o every time a box is clicked
            x = !x;


        }

        //Whenever a picturebox is clicked the changer method is called
        private void pictureBox_Click(object sender, EventArgs e)
        {
            Changer(sender);
        }

        //The reset button calls the ClearGrid method, which is also called on the form load event
        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        //This method sets all variables in thGrid to 0, blanks the images and re-enables the pictureboxes, effectivly restarting the game
        private void ClearGrid()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    theGrid[row, col] = 0;
                }

            }


            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;


            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }

        //The board is cleard on load just to be consistent
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearGrid();
        }
    }
}
