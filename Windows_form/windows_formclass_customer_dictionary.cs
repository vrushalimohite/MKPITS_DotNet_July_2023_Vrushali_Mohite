﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_class_customer_directionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Customer> c = new Dictionary<int, Customer>();
        private void button1_Click(object sender, EventArgs e)
        {
            c.Add(Convert.ToInt32(textBox1.Text),(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            c.Add(c1.rollno, c1);
        }
    }
}
