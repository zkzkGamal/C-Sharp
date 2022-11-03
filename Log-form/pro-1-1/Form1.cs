using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace pro_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Users\zkzk\Documents\Visual Studio 2010\Projects\pro-1-1\DB\loginDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "Select * from tbl_log Where username = '" + textBox1.Text.Trim() + "'and password ='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable Dtbl = new DataTable();
            sda.Fill(Dtbl);
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\zkzk\Documents\Visual Studio 2010\Projects\pro-1-1\DB\Database1.accdb");
            string slec = "Select * from table1 Where name = '"+textBox1.Text.Trim()+"'and Password = '" +textBox2.Text.Trim() + "'";
            OleDbDataAdapter ssa = new OleDbDataAdapter(slec, con);
            DataTable dtbe = new DataTable();
            ssa.Fill(dtbe);
            if (dtbe.Rows.Count == 1)
            {
                this.Hide();
                Form3 form_3 = new Form3();
                form_3.Show();
            }
            else if (Dtbl.Rows.Count == 1)
            {
                this.Hide();
                Form3 form_3 = new Form3();
                form_3.Show();
            }
            else
            {
                MessageBox.Show("please check your pass or username");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 forma2 = new Form2();
            forma2.Show();
        }

    }
}