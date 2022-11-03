using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clac_comb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("sum");
            comboBox1.Items.Add("sub");
            comboBox1.Items.Add("mul");
            comboBox1.Items.Add("div");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "sum"){
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x + y);
            }
            if (comboBox1.SelectedItem == "sub")
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x - y);
            }
            if (comboBox1.SelectedItem == "mul")
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x * y);
            }
            if (comboBox1.SelectedItem == "div")
            {
                float x = Convert.ToInt32(textBox1.Text);
                float y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x / y);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            float x = Convert.ToInt32(textBox1.Text);
            float y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(x / y);
        }

        
    }
}
