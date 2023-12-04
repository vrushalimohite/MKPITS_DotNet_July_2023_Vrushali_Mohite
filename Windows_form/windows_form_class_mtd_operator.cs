using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_class_mtd_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        @operator op = new @operator();

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            string ope = textBox3.Text;
            op.display(num1, num2,ope);
            label4.Text = op.result.ToString();

        }

       
    }
}
