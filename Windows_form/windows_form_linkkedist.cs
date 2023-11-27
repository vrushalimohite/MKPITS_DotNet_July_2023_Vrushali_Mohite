using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormslinkedlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList<int> li = new LinkedList<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.AddLast(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int i in li)
            {
                sb.Append("num" + i + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li.AddFirst(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }
    }
}
