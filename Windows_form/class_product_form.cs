using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_product_form_name_qun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int squantity = 0; int uquantity = 20;
        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.name = textBox1.Text;
            p.quantity = Convert.ToInt32(textBox2.Text);
            p.price= Convert.ToInt32(textBox3.Text);
            squantity = uquantity - p.quantity;

            StringBuilder sb = new StringBuilder();
            sb.Append("Product Name :" + p.name + "\n");
            sb.Append("Product Quantity:" + p.quantity + "\n");
            sb.Append("Product Price:" + p.price + "\n");
            sb.Append(" " + "\n");
            sb.Append(" Message For Shopkeeper " + "\n");
           


            sb.Append("\nUpdated Stock Quantity : " +squantity);

            label4.Text = sb.ToString();

        }
    }
}
