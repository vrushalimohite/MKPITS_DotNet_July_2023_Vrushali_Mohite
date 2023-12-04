using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_students_data_using_chekbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int rollno = Convert.ToInt32(textBox2.Text);
            string total;
            if(checkBox1.Checked)
            {
                 total = "Total Students Appered Subject = 09";
                label6.Text = total;
            }
            else if(checkBox2.Checked)
            {
                 total = "Total students Appered subject = 15";
                label6.Text = total;
            }
            label4.Text = name.ToString();
            label5.Text = rollno.ToString();
        }
    }
}
