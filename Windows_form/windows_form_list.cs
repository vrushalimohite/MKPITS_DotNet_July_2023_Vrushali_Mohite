using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> si = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            si.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in si)
            {
                sb.Append("Subject Name :" + s + "\n");
            }
            label2.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            si.Remove(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            si.Insert(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            si.Sort();
        }
    }
}
