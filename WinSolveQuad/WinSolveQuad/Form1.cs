using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSolveQuad
{
    public partial class Form1 : Form
    {

        //Global variable
        Equation quadFormula = new Equation();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void IsReadyToSolve()
        {
            if (tbTermA.BackColor == Color.LightGreen && tbTermB.BackColor == Color.LightGreen && tbTermC.BackColor == Color.LightGreen)
            {
                solveEquation.Enabled = true;
                solveEquation.Font = new Font(solveEquation.Font, FontStyle.Bold);
            }
        }

        private void solveEquation_Click(object sender, EventArgs e)
        {
            EquationLabel.Text = quadFormula.PrintFormula();
            x1Solution.Text = quadFormula.CalcXAdd();
            x2Solution.Text = quadFormula.CalcXSub();

            resetEquation.Enabled = true;
        }

        private void ClearTerm(TextBox whichBox)
        {
            whichBox.Text = "";
            whichBox.BackColor = Color.White;
        }

        private void resetEquation_Click(object sender, EventArgs e)
        {
            //Reset equation button
            quadFormula = new Equation();

            //Reset solve button
            solveEquation.Font = new Font(solveEquation.Font, FontStyle.Regular);

            //Disable buttons
            solveEquation.Enabled = false;
            resetEquation.Enabled = false;

            //Clear term boxes
            ClearTerm(tbTermA);
            ClearTerm(tbTermB);
            ClearTerm(tbTermC);

            //Clear labels
            EquationLabel.Text = "";
            x1Solution.Text = "";
            x2Solution.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1Label.Text = "X\u2081";
            x2Label.Text = "X\u2082";
        }

        private void TermUpdated(object sender, EventArgs e)
        {
            TextBox tempTextBox;

            tempTextBox = (TextBox)sender;

            double numericValue;

            if (double.TryParse(tempTextBox.Text, out numericValue))
            {
                switch (tempTextBox.Name)
                {
                    case "tbTermA":
                        quadFormula.TermA = numericValue;
                        break;
                    case "tbTermB":
                        quadFormula.TermB = numericValue;
                        break;
                    case "tbTermC":
                        quadFormula.TermC = numericValue;
                        break;
                }

                tempTextBox.BackColor = Color.LightGreen;
                IsReadyToSolve();
            }
            else
            {
                tempTextBox.BackColor = Color.LightCoral;
                solveEquation.Font = new Font(solveEquation.Font, FontStyle.Regular);
                solveEquation.Enabled = false;
            }
        }
    }
}