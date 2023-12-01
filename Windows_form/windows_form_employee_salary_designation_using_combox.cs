using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_employee_salary
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
            int sal = Convert.ToInt32(textBox2.Text);
            float hra = 0;
            float bonus = 0;
            if(comboBox1.Text =="Manager")
            {
                hra = sal*0.35f;
                bonus = sal + 1000;
            }
            else if(comboBox1.Text=="Clerk")
            {
                hra = sal * 0.25f;
                bonus = sal + 700; 

            }
            else if(comboBox1.Text=="Peun")
            {
                hra = sal * 0.15f;
                bonus = sal + 500;
               
            }
            float totalsal = hra + bonus;
            label4.Text = "Employee Name :"+name;
            label5.Text = "Basic Salary :"+sal;
            label6.Text = "House Rent Allowence :"+hra;
            label7.Text = "Bonus :"+bonus;
            label8.Text = "Total Salary :"+totalsal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
