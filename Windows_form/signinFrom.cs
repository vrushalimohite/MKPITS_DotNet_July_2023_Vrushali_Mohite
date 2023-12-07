using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_register_acc
{
    public partial class signinFrom : Form
    {
        public signinFrom()
        {
            InitializeComponent();
        }

        private void signinFrom_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Vrushali" ||  textBox2.Text=="Vrushali" )
            {
                MessageBox.Show("Your Registration Sucessful !");
            }
           else if (textBox1.Text == "Mayuri" || textBox2.Text == "Mayuri")
            {
                MessageBox.Show("Your Registration Sucessful !");
            }
            else    if (textBox1.Text == "Sahil" || textBox2.Text == "Sahil")
            {
                MessageBox.Show("Your Registration Sucessful !");
            }
           else  if (textBox1.Text == "Priya" || textBox2.Text == "Priya")
            {
                MessageBox.Show("Your Registration Sucessful !");
            }
            else if (textBox1.Text == "Mrunal" || textBox2.Text == "Mrunal")
            {
                MessageBox.Show("Your Registration Sucessful !");
            }
            else
            {
                MessageBox.Show("Invalid Details!");

            }
            checkBox1.Checked = true;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Check your Email");
        }
    }
}
