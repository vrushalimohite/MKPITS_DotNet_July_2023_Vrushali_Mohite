using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsForms_stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in s)
            {
                sb.Append(s + " "+"\n");
            }
            label2.Text = sb.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
            StringBuilder sb1 = new StringBuilder();
            foreach (string c in s)
            {
                sb1.Append(c + " " + "\n");
            }
            label3.Text = sb1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         s.Pop().ToString();
            StringBuilder sb2 = new StringBuilder();
            foreach (string s1 in s)
            {
                sb2.Append( s1+"\n");
              
            }
            label4.Text = sb2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
