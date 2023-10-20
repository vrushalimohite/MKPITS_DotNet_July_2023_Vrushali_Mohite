using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_marks_sub_total_per_grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string grade;
           int math = Convert.ToInt32(textBox1.Text);
           int phy = Convert.ToInt32(textBox2.Text);
           int che = Convert.ToInt32(textBox3.Text);
           int total = math + phy + che;
            label4.Text = "Total :" + total;
            float per = total / 300.0f * 100.0f;
            label5.Text="percentage :"+per;
            if(per>=75)
                grade = "distinction";
            else if(per>=60 && per<75)
                grade = "First class";
            else if(per>=40 && per<60)
                grade = "Second class";
            else
                grade = "Fail";
            label6.Text = "grade" + grade;

        }

    }
}
