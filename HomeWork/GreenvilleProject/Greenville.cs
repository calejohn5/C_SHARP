using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise4
{
    public partial class Greenville : Form
    {
        public Greenville()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cj = textBox1.Text;
            label3.Text= "Thank you for entering" + cj;
        }
    }
}
