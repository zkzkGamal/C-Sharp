using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pro_1_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = 1;
                for (int i = 1; i <= x; i++)
                {
                    y = y * i;
                }
                textBox3.Text = Convert.ToString(y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(x + y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(x - y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(x * y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(x / y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = Convert.ToString(Math.Sin(x));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = Convert.ToString(Math.Cos(x));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = Convert.ToString(Math.Tan(x));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox3.Text = Convert.ToString(Math.Log(x));
        }
    }
}
