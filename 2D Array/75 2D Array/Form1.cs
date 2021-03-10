using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _75_2D_Array
{
    public partial class Form1 : Form
    {
        //Global variables
        int[,] theNumbers = new int[3, 3];

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadArray()
        {
            Random ranNumber = new Random();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    theNumbers[row, col] = ranNumber.Next(10);
                }
            }
        }

        private void LoadForm()
        {
            box00.Text = theNumbers[0, 0].ToString();
            box01.Text = theNumbers[0, 1].ToString();
            box02.Text = theNumbers[0, 2].ToString();
            box10.Text = theNumbers[1, 0].ToString();
            box11.Text = theNumbers[1, 1].ToString();
            box12.Text = theNumbers[1, 2].ToString();
            box20.Text = theNumbers[2, 0].ToString();
            box21.Text = theNumbers[2, 1].ToString();
            box22.Text = theNumbers[2, 2].ToString();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadArray();
            LoadForm();
        }

        private int SumRow(int whichRow)
        {
            int rowSum = 0;

            for (int col = 0; col < 3; col++)
            {
                rowSum += theNumbers[whichRow, col];
            }

            return rowSum;
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row0Sum.Text = (SumRow(0)).ToString();
            row0Sum.Text = (SumRow(1)).ToString();
            row0Sum.Text = (SumRow(2)).ToString();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            row0Sum.Text = (SumRow(0)).ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            row0Sum.Text = (SumRow(1)).ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            row0Sum.Text = (SumRow(2)).ToString();
        }

        private int SumCol (int whichCol)
        {
            int rowCol = 0;

            for (int col = 0; col < 3; col++)
            {
                rowCol += theNumbers[whichCol, col];
            }

            return rowCol;
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagLRSum = (theNumbers[0, 0] + theNumbers[1, 1] + theNumbers[2, 2]).ToString();
        }

        private void rightToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagRLSum = (theNumbers[0, 2] + theNumbers[1, 1] + theNumbers[2, 0]).ToString();
        }
    }
}