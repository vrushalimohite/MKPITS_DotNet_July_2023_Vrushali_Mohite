using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_if_else_electric_bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int id, unit;
            float total=0;
            float surchage = 0;
            double netamount = 0;
            name = (textBox1.Text);
            id = Convert.ToInt32(textBox2.Text);
            unit= Convert.ToInt32(textBox3.Text);
            if(unit>0 && unit<=199)
            {
                total = unit * 1.20f;
            }
            else if(unit>=200 && unit<=400)
            {
                total = unit * 1.50f;
            }
            else if(unit>400 && unit<=600)
            {
                total = unit * 1.80f;
            }
            else if(unit>600)
            {
                total = unit * 2.00f;
            }
            if (total>=400)
                surchage = total * 0.15f;
            netamount = total + surchage;
            label4.Text = "Employee Name :" + name;
            label5.Text = "Employee Id :" + id;
            label6.Text = "Unit consumed :" + unit;
            label7.Text = "Amount Charge :" + total;
            label8.Text = "Surchage Amount :" + surchage;
            label9.Text = "Net Amount paid by the customed :" + netamount;



        }
    }
}
