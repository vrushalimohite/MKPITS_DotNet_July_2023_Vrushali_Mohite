using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_students_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            string age=numericUpDown1.Text;

            if (textBox1.Text == " " & numericUpDown1.Value==0)
            {
                MessageBox.Show("FILL THE STUDENTS NAME AND AGE");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("ENTER YOUR NAME");
            }
            if(numericUpDown1.Value==0)
            {
                MessageBox.Show("ENTER YOUR AGE");
            }
            else if (numericUpDown1.Value <= 18)
            {
                MessageBox.Show(" Enter valid students age");
            }
            
            sb.Append("STUDENTS NAME :" + textBox1.Text + "\n");
            sb.Append("STUDENTS AGE :" + numericUpDown1.Value + "\n");
            label4.Text = sb.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;

          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
