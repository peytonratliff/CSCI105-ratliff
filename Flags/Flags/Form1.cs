using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxFinland_Click(object sender, EventArgs e)
        {
            labelCountryName.Text = ("Finland");
        }

        private void pictureBoxFrance_Click(object sender, EventArgs e)
        {
            labelCountryName.Text = ("France");
        }

        private void pictureBoxGermany_Click(object sender, EventArgs e)
        {
            labelCountryName.Text = ("Germany");
        }
    }
}
