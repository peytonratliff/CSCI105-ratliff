using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowBack_Click(object sender, EventArgs e)
        {
            pictureBoxCardBack.Visible = true;
            pictureBoxCardFront.Visible = false;
        }

        private void buttonShowFront_Click(object sender, EventArgs e)
        {
            pictureBoxCardBack.Visible = false;
            pictureBoxCardFront.Visible = true;
        }
    }
}
