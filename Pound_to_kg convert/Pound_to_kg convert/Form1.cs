using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pound_to_kg_convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] p = { "Pounds", "Kilograms" };
            string[] k = { "Kilograms", "Pounds" };
            comboBox1.DataSource = p;
            comboBox2.DataSource = k;
            // This is the form for conversion.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start_weight, result_weight;
            start_weight = double.Parse(textBox1.Text);
            if (comboBox1.Text == "Pounds" && comboBox2.Text == "Kilograms")
            {
               
                result_weight = ((start_weight * 227) / 500);
                label3.Text = result_weight.ToString() + " kg";
            }
            if (comboBox1.Text == "Kilograms" && comboBox2.Text == "Pounds")
            {
                result_weight = ((start_weight * 500) / 227);
                label3.Text = result_weight.ToString() + " lbs";
            }
            if (comboBox1.Text == "Kilograms" && comboBox2.Text == "Kilograms")
            {
                result_weight = start_weight;
                label3.Text = result_weight.ToString() + " kg";
            }
            if (comboBox1.Text == "Pounds" && comboBox2.Text == "Pounds")
            {
                result_weight = start_weight;
                label3.Text = result_weight.ToString() + " lbs";
            }
        }
    }
}
