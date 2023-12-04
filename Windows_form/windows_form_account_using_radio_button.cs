using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_account_using_radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int acno = Convert.ToInt32(textBox1.Text);
            string aname = (textBox2.Text);
            int amt = Convert.ToInt32(textBox3.Text);
            if(radioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(radioButton2.Checked)
            {
                bal = bal - amt;
            }
            label5.Text ="Account Number :"+ acno.ToString();
            label6.Text = "Account Holder Name :"+aname.ToString();
            label7.Text = "Total Balance :"+bal.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
