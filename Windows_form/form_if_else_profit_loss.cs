using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_if_else_profit_loss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c, s;
            int result;
            c = Convert.ToInt32(textBox1.Text);
            s = Convert.ToInt32(textBox2.Text);
            if(s>c)
            {
                result = s - c;
                label3.Text="Profit :"+result;
            }
            else 
            {
                result = c - s;
                label3.Text = "Loss :" + result;


            }

        }
    }
}
