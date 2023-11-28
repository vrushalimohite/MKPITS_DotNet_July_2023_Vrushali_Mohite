using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_class_product_dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Product> d = new Dictionary<int, Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            Product p1 = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text,Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            d.Add(Convert.ToInt32(textBox1.Text), p1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("Details Sucessfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Product>kvp in d)
            {
                int amount = kvp.Value.pamount* kvp.Value.pqun;
                total = total + amount;
                sb.Append("Product NO : " + kvp.Key +"\n"+ " Product Name : " + kvp.Value.pname + "\n" + " Product Quantity :" + kvp.Value.pqun + "\n" + "Product Amount : " + kvp.Value.pamount+ "\n"+"Toatal Amount ="+total);

            }
            //label7.Text = sb.ToString();
            richTextBox1.Text = sb.ToString();

            MessageBox.Show("total amount " + total);
        }
    }
}
