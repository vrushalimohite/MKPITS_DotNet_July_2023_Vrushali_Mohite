using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsForms_typing_master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.ShowDialog();
            fm.Show();
          
           
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS01;integrated security=true;database=typing_login");
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "insert into login values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand command= new SqlCommand(st,con);
            command.ExecuteNonQuery();
            con.Close();

            this.Hide();
            frmMain fm = new frmMain();
            fm.ShowDialog();
            fm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Check your Email");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME");
        }
    }
}
