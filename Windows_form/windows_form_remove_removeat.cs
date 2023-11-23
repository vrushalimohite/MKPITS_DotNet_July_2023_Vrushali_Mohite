using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_remove_removeat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(object ob in ar)
            {
                sb.Append("User Information :" + ob.ToString() + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Remove(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            ar.RemoveAt(num);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ar.Insert(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
