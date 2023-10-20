using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_new_designation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empid;
           
            int basicsal=0;
            int totalsal=0;
            string name, designation;
            name = (textBox1.Text);
            empid = Convert.ToInt32(textBox2.Text);
            basicsal = Convert.ToInt32(textBox3.Text);
            designation = (textBox4.Text);
            if (designation == "maneger")
            {
                totalsal = basicsal + 5000;
            }
            else if (designation == "clerk")
            {
                totalsal = basicsal + 2000;

            }
            else if (designation == "peun")
            {
                totalsal = basicsal + 1000;

            }
            

            label5.Text = "Employee Name :"+name;
            label6.Text = "Empid :" + empid;
            label7.Text = "Totalsal :" + totalsal;
            label8.Text = "Designation :"+designation;
        }

       
    }
}
