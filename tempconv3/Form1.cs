using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempconv3
{
    public partial class Form1 : Form
    {
        Degrees degrees = new Degrees();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CTF.Checked)
            {
                double val = double.Parse(textBox1.Text);
                label2.Text = degrees.CTF(val).ToString();
            }
            else if (FTC.Checked)
            {
                double val = double.Parse(textBox1.Text);
                label2.Text = degrees.FTC(val).ToString();
            }
        }
    }
}
