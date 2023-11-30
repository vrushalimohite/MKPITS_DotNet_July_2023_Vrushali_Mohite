using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using method;

namespace WindowsForms_class_calculate_mtd_add_sub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculate c = new calculate();
        private void button1_Click(object sender, EventArgs e)
        {
            int r = c.addition(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            label3.Text = "Addition of Two no :" + r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = c.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Subtract Two no :" + r;
        }
    }
}
/*sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
 public class calculate
 {
  public int addition(int n1,int n2)
     {
         int result = n1 + n2;
         return result;
     }
     public int substraction(int n1,int n2)
     {
         int result = n1 - n2;
         return result;
     }
 }
}*/