using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_total_per_grade_subject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math, phy, che;
            string grade;
            float total, per;
             math = Convert.ToInt32(textBox1.Text);
             phy= Convert.ToInt32(textBox2.Text);
             che = Convert.ToInt32(textBox3.Text);
            total = math + phy + che;
            
            label4.Text = "total :" + total;
            if (total > 300)
            {
                label4.Text = "Invalid Marks";
            }

            per = total / 300.0f * 100.0f;
            label5.Text = "percentage :" + per;
            if (per > 100)
            {
                label5.Text = "Invalid Total";
            }
            if (per > 100)
            {
                grade = "Invalid Percentage";
            }

            else if (per >= 75 && per <= 100)
                grade = "desinction";
            else if (per >= 60 && per < 75)
                grade = "first class";
            else if (per >= 40 && per < 60)
                grade = "secound class :";
            else
                grade = "Fail";
            label6.Text = "Grade :" + grade;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
