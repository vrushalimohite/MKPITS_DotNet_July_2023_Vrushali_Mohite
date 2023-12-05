using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_product_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text)
            {
                case "LAPTOP":
                    comboBox2.Items.Add("DELL");
                    comboBox2.Items.Add("ACER");
                    comboBox2.Items.Add("HP");
                    break;
                case "DIGITAL WATCH":
                    comboBox2.Items.Add("NOISE");
                    comboBox2.Items.Add("BOAT");
                    break;
                case "MOBAIL":
                    comboBox2.Items.Add("REALMI 7I");
                    comboBox2.Items.Add("VIVO");
                    comboBox2.Items.Add("REDMI");
                    break;
                case "COMPUTER":
                    comboBox2.Items.Add("MOUSE");
                    comboBox2.Items.Add("KEYBOARD");
                    comboBox2.Items.Add("PRINTER");
                    break;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int amt = Convert.ToInt32(textBox2.Text);
            int quan = Convert.ToInt32(textBox3.Text);
            sb.Append("PRODUCT NAME :"+textBox1.Text+"\n");
            sb.Append("MOBAIL NUMBER :"+maskedTextBox1.Text+"\n");
            sb.Append("PRODUCT NAME :"+comboBox1.Text+"\n");
            

            sb.Append("PRODUCT MODEL :" + comboBox2.Text+"\n");
            sb.Append("PRODUCT AMOUNT :"+textBox2.Text+"\n");
            sb.Append("PRODUCT QUANTITY :"+textBox3.Text+"\n");

            int result = amt * quan;
            sb.Append("TOTAL AMOUNT :"+result);
            label8.Text = sb.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
