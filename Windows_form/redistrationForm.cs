using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_register_acc
{
    public partial class redistrationForm : Form
    {
        public redistrationForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name :" + textBox1.Text+"\n");
            sb.Append("Mobail No :" + maskedTextBox1.Text+"\n");
            sb.Append("Email Address :" + textBox2.Text + "\n");
            sb.Append("COUNTRY :" + comboBox1.Text + "\n");
            sb.Append("CITY :" + comboBox2.Text + "\n");
            label7.Text = sb.ToString();
            signinFrom sf = new signinFrom();
            sf.ShowDialog();
            sf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text)
            {
                case "INDIA":
                    comboBox2.Items.Add("NAGPUR");                 
                        comboBox2.Items.Add("AMRAVTI");

                    comboBox2.Items.Add("PUNE");
                    comboBox2.Items.Add("WARDHA");
                    comboBox2.Items.Add("YAVTMAL");
                    break;
                case "USA":
                    comboBox2.Items.Add("Phoenix");
                    comboBox2.Items.Add("New York");
                    break;
                case "AFRICA":
                    comboBox2.Items.Add("Addis Ababa");
                    comboBox2.Items.Add("Nairobi");
                    comboBox2.Items.Add("Bujumbura");
                    break;
                case "THAILAND":
                    comboBox2.Items.Add("Bangkok");
                    comboBox2.Items.Add("Kanchanaburi");
                    break;

            }

        }
    }
}
