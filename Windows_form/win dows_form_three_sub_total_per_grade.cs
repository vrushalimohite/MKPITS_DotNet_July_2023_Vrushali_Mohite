using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_three_subject_marks_per_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int total = num1 + num2 + num3;
            label4.Text = total.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int total = num1 + num2 + num3;
            float per = total / 300.0f * 100;
            label5.Text = per.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int num3 = Convert.ToInt32(textBox3.Text);
            int total = num1 + num2 + num3;
            float per = total / 300.0f * 100;
            if (per > 75)
            {
                label6.Text = "A";
            }
            else if (per > 60 || per < 75)
            {
                label6.Text = "B";
            }
            else if (per < 60 || per > 40)
            {
                label6.Text = "c";
            }
            else if (per < 40)
            {
                label6.Text = "Fail";
            }
        }
    }
}
