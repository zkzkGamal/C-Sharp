using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sin_cos_tan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(Math.Sin(x));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(Math.Cos(x));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(Math.Tan(x));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label3.Text = Convert.ToString(Math.Log(x));
        }
    }
}
