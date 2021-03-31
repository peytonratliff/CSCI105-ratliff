using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGeneratorGUI
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            Character tempData = (Character)this.Tag;

            labelCharacterName.Text = "Your character's name is "+tempData.Name;
            labelRaceClass.Text = tempData.Name + " is a " + tempData.Race + " " + tempData.Class;
            labelStrength.Text = tempData.Name + "'s cumulative strength is " + tempData.Strength;
            labelAgility.Text = tempData.Name + "'s cumulative agility is " + tempData.Agility;
            labelIntellect.Text = tempData.Name + "'s cumulative intellect is " + tempData.Intellect;
            labelStamina.Text = tempData.Name + "'s cumulative stamina is " + tempData.Stamina;

        }
    }
}
