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
   public partial class SummaryForm : Form
   {
      public SummaryForm()
      {
         InitializeComponent();
      }

      private void SummaryForm_Load(object sender, EventArgs e)
      {
         // Recast the .Tag object property into a Player object
         Player passData = (Player)this.Tag;

         // Load the label with the summary information
         summaryLabel.Text = passData.SummaryData();
      }
   }
}
