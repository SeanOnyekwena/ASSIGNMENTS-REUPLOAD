using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculation
{
    public partial class Form1 : Form
    {
        double height;
        double weight;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtBMI.BackColor = Color.White;
            height = Double.Parse(textBox2.Text);
            weight = Double.Parse(textBox1.Text);

            total = weight / (height * height);
            TxtBMI.Text = String.Format("{0:f}", total);

            if (total <= 24.9)
            {
                TxtBMI.BackColor = Color.PowderBlue;
            }
            else if (total <= 29.9)
            {
                TxtBMI.BackColor = Color.Blue;
            }
            else if (total <= 34.9)
            {
                TxtBMI.BackColor = Color.Yellow;
            }
            else if (total <= 39.9)
            {
                TxtBMI.BackColor = Color.Red;
            }
            else if (total >= 40)
            {
                TxtBMI.BackColor = Color.DarkRed;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            TxtBMI.Text = "";
            TxtBMI.BackColor = Color.White;
        }
    }
}
