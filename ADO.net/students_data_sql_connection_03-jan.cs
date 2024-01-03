using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace students_form_sql_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            students s = new students();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "male";
            }
            if(radioButton2.Checked)
            {
                g = "female";
            }
            string h= null;
            if(checkBox1.Checked)
            {
                h = "music";
            }
            if(checkBox2.Checked)
            {
                if(h!=null)
                {
                    h = h + " " + "reading";
                }
            }

            else
            {
                h = "reading";
            }

            string result = s.insertstudent_sql(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            Cleartext();


        }
        public void Cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            students s = new students();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "male";
            }
            if (radioButton2.Checked)
            {
                g = "female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + " " + "reading";
                }
            }

            else
            {
                h = "reading";
            }

            string result = s.updatestudent_sql(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            Cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students s = new students();
            string result = s.deletestudent_sql(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text = result;
            Cleartext();

        }
    }
}
