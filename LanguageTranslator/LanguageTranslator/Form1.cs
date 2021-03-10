using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonItalian_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = ("Buongiorno");
        }

        private void ButtonSpanish_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = ("Buenos Dias");
        }

        private void ButtonGerman_Click(object sender, EventArgs e)
        {
            labelTranslation.Text = ("Guten Morgen");
        }
    }
}
