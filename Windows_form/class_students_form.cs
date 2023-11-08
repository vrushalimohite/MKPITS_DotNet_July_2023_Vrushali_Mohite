using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_students_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Students[] stud = new Students[3];
        int cnt = 0;
        int[] total = new int[3];
        float[] avr = new float[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Students();
            stud[1] = new Students();
            stud[2] = new Students();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                stud[cnt].name = textBox1.Text;
                stud[cnt].rollno = Convert.ToInt32(textBox2.Text);
                stud[cnt].marks1 = Convert.ToInt32(textBox3.Text);
                stud[cnt].marks2 = Convert.ToInt32(textBox4.Text);
                stud[cnt].marks3 = Convert.ToInt32(textBox5.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();

                if (cnt == 3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("All Information Done..Click to click button");

                }
            }
            for (int cnt = 0; cnt < 3; cnt++)
            {
                total[cnt] = stud[cnt].marks1 + stud[cnt].marks2 + stud[cnt].marks3;
                avr[cnt] = total[cnt] / 3;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int cnt =0;cnt<3;cnt++)
            {
                sb.Append("Students Name :" + stud[cnt].name + "\n");
                sb.Append("students Rool No :" + stud[cnt].rollno + "\n");
                sb.Append("Marks 1 :" + stud[cnt].marks1 + "\n");
                sb.Append("Marks 2 :" + stud[cnt].marks2 + "\n");
                sb.Append("Marks 3 :" + stud[cnt].marks3 + "\n");
                sb.Append("Total Marks :" + total[cnt] + "\n");

                sb.Append("Average :" + avr[cnt] + "\n");
                

            }
            label4.Text = sb.ToString();
        }
    }
}
