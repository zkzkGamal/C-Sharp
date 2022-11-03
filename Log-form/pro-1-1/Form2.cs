using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pro_1_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\zkzk\Documents\Visual Studio 2010\Projects\pro-1-1\DB\Database1.accdb");
            if (textBox2.Text == textBox3.Text)
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into table1 values('" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data now added to accses");
            }
            else
            {
                MessageBox.Show("Please Checked your password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.Show();
        }

    }
}
