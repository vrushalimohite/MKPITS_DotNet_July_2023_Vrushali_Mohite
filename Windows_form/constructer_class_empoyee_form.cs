using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructer_class_employee_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Name :" + emp.name + "\n");
            sb.Append("Employee ID :" + emp.id + "\n");
            sb.Append("Designation :" + emp.designation + "\n");
            sb.Append("Empolyee Salary :" + emp.salary + "\n");
            label5.Text = sb.ToString();
        }
    }
}
/*Class Code*/
/*
 internal class Employee
    {
        public string name { get; set; }
        public int id { get; set; }
        public string designation { get; set; }
        public int salary { get; set; }

        public Employee(string name, int id, string designation, int salary)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            this.salary = salary;

        }
    }
 */