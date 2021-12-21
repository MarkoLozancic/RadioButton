using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnrezerviraj_Click(object sender, EventArgs e)
        {
            if (rbtnavion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz zrakoplovom";
            }
            else if(rbtnbus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz autobusom";

            }
            else if(rbtnvlak.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz vlakom";

            }
        }
    }
}
