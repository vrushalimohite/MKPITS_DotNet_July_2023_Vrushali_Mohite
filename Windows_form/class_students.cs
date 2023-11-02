using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Students[] stud = new Students[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Students();
            stud[1] = new Students();
            stud[2] = new Students();
            stud[3] = new Students();
            stud[4] = new Students();
            stud[5] = new Students();
            stud[6] = new Students();
            stud[7] = new Students();
            stud[8] = new Students();
            stud[9] = new Students();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                stud[cnt].Name = textBox1.Text;
                stud[cnt].Roll_no = Convert.ToInt32(textBox2.Text);
                stud[cnt].Fees = Convert.ToDouble(textBox3.Text);
                stud[cnt].Date = Convert.ToInt32(textBox4.Text);

                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled=true;
                    MessageBox.Show("Highest Fees Paid students details ");


                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Students Details are :");
            for(int i=0; i<9;i++)
            {
                sb.Append("--------------------------"+"\n");
                sb.Append("Students Name :" + stud[i].Name + "\n");
                sb.Append("Students Roll No  :" + stud[i].Roll_no + "\n");
                sb.Append("Students Fees :" + stud[i].Fees + "\n");
                sb.Append("Fees Paid Date :" + stud[i].Date + "\n");
                sb.Append("--------------------------"+"\n");

            }
            label4.Text = sb.ToString();
            double high = stud[0].Fees;
            int flag = 0;
            for(int i=0;i<9;i++)
            {
                for(int j=0;j<9;j++)
                {
                    if (high < stud[i].Fees)
                    {
                        high = stud[i].Fees;
                        flag = i;
                    }
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Students Name :" + stud[flag].Name + "\n");
            sb1.Append("Students Roll No  :" + stud[flag].Roll_no + "\n");
            sb1.Append("Students Fees :" + stud[flag].Fees + "\n");
            sb1.Append("Fees Paid Date :" + stud[flag].Date + "\n");
            sb.Append("--------------------------");

            label6.Text = sb1.ToString();
        }
    }
}
/*Class Code*/

/*namespace class_students
{
    internal class Students
    {
        public string Name { get; set; }
        public int Roll_no { get; set; }
        public double Fees { get; set; }
        public int Date { get; set; }
    }
}
*/