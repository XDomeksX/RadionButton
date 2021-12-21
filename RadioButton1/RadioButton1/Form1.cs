using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BRezerviraj_Click(object sender, EventArgs e)
        {
            if (RBAvion.Checked)
            {
                TB1.Text = "Odabrali ste prijevoz avionom.";
            }
            if (RBAutobus.Checked)
            {
                TB1.Text = "Odabrali ste prijevoz autobusom.";
            }
            if (RBVlastiti.Checked)
            {
                TB1.Text = "Odabrali ste prijevoz vlastitim prijevozom.";
            }
        }
    }
}
