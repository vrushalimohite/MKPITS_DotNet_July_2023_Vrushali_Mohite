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

namespace WindowsForm_queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue q = new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string c in q )
            {
                sb.Append(c+"\n");
            }
            label2.Text = sb.ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            q.Dequeue();
            StringBuilder sb1 = new StringBuilder();
            foreach (string c in q)
            {
                sb1.Append(c + "\n");
            }
            label3.Text = sb1.ToString();
        }
    }
}
