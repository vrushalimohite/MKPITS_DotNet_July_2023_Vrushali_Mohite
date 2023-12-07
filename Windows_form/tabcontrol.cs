using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_tab_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Admin" || textBox2.Text=="Admin")
            {
                MessageBox.Show("Sucessfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vrushali" || textBox2.Text == "123")
            {
                MessageBox.Show("successfully");
            }

        }
    }
}
