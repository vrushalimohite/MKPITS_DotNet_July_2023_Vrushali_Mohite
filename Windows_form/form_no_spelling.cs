using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_nu_spelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);
            if (num == 1)
                label2.Text = "ONE";
            else if(num==2)
                label2.Text = "TWO";
            else if(num==3)
                label2.Text = "THREE";
            else if(num==4)
                label2.Text = "FOUR";
            else if(num==5)
                label2.Text = "FIVE";
            else if(num==6)
                label2.Text = "SIX";
            else if(num==7)
                label2.Text = "SEVEN";
            else if(num==8)
                label2.Text = "EIGHT";
            else if(num==9)
                label2.Text = "NINE";
            else if(num==10)
                label2.Text = "TEN";
            else
                label2.Text = "INVALID NO";

        }
    }
}
