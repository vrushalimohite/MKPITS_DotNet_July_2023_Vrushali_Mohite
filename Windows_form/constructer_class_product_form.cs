using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructor_with_parm_class_product_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Bookid :" +p. productid + "\n");
            sb.Append  ("Product Name :" + p.productname + "\n");
            sb.Append ("Product Price :" + p.productprice + "\n");
            sb.Append ("Product Quantity :" + p.productquantity + "\n");
            label5.Text = sb.ToString();
        }
    }
}
