using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62_Control_Review
{
   public partial class SimpleForm : Form
   {
      public SimpleForm()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
