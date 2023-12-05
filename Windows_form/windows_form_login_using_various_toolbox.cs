using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("USERNAME :"+textBox1.Text+"\n");
            sb.Append("PASSWORD :"+textBox2.Text+"\n");
            if(radioButton1.Checked)
            {
                string gen = "FEMALE";
                sb.Append("GENDER :" + gen+"\n");

            }
            else if(radioButton2.Checked)
            {
                sb.Append("GENDER:" + radioButton1.Text + "\n");

            }
            if(checkBox1.Checked)
            {
                string des = "HR";
                sb.Append("DESIGNATION :" + des+"\n");

            }
            else if(checkBox2.Checked)
            {
                string des = "MANAGER";
                sb.Append("DESIGNATION :" + des+"\n");
            }
            sb.Append("DESIGNATION :" + comboBox1.Text + "\n");
            sb.Append("SHIFT :" + comboBox2.Text + "\n");

            label7.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            if(comboBox1.Text=="CLOUD")
            {
                comboBox2.Items.Add("fIRST SHIFT");
                comboBox2.Items.Add ( "GENERAL SHIFT");

            }
            else if(comboBox1.Text=="TESTTING")
            {
                comboBox2.Items.Add("fIRST SHIFT");
                comboBox2.Items.Add ( "DAY SHIFT");
            }
            else if(comboBox1.Text=="MARKATING")
            {
                comboBox2.Items.Add ("GENERAL SHIFT");
            }
            else if(comboBox1.Text=="DESIGNING")
            {
                comboBox2.Items.Add( "fIRST SHIFT");
                comboBox2.Items.Add ( "GENERAL SHIFT");
            }
        }
    }
}
