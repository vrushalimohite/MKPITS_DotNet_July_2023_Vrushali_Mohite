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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redistrationForm rf = new redistrationForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void signinFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signinFrom sf = new signinFrom();
            sf.MdiParent = this;
            sf.Show();
        
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redistrationForm rf = new redistrationForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void signinFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            signinFrom sf = new signinFrom();
            sf.MdiParent=this;
            sf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            redistrationForm rf = new redistrationForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Admin" || textBox2.Text=="Admin")
            {
                panel1.Visible = false;
                registrationFromToolStripMenuItem.Enabled= true;
                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
                redistrationForm rf = new redistrationForm();
                rf.ShowDialog();
                rf.Show();

            }
            else
            {
                MessageBox.Show("ENTER CORRECT INFORMATION");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
