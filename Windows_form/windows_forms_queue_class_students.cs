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

namespace WindowsForms_queue_class_students
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
            q.Enqueue(textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(String val in q)
            {
                sb.Append(val + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            q.Dequeue();
            foreach(string s in q)
            {
                sb.Append(s + "\n");
            }
            label4.Text = sb.ToString();
        }
    }
}
