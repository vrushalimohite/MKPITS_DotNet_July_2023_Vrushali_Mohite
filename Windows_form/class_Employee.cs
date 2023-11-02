using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_employee_highest_sal_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();          
            emp[1] = new Employee();

            emp[2] = new Employee();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].EmployeeID = Convert.ToInt32(textBox1.Text);
                emp[cnt].Name = textBox2.Text;
                emp[cnt].Salary = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 3 Employeed Accepted :");


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee details are :" + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("----------------------------------"+"\n");
                sb.Append("EmployeeID :" + emp[i].EmployeeID + "\n");          
                sb.Append("EmployeeName :" + emp[i].Name + "\n");

                sb.Append("Employee Salary :" + emp[i].Salary + "\n");

                sb.Append("----------------------------------");

            }
            label4.Text = sb.ToString();
            double high = emp[0].Salary;
            int flag = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=i+1;j<3;j++)
                {
                    if (high <emp[i].Salary)
                    {
                        high = emp[i].Salary;
                        flag = i;
                    }
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Employee with highest salary :"+"\n");
            sb1.Append("EmployeeID :" + emp[flag].EmployeeID + "\n"); 
            sb1.Append("EmployeeName :" + emp[flag].Name + "\n");
            sb1.Append("Employee Salary :" + emp[flag].Salary + "\n");
            label5.Text = sb1.ToString();

        }
    }
}
