﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int total = num1 + num2;
            label3.Text = "Addition :" + total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int total = num1 - num2;
            label3.Text = "Substraction :" + total;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);

            int total = num1 * num2;

            label3.Text = "Multiplication :" + total;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);

            int num2 = Convert.ToInt32(textBox2.Text);
            float total = num1 / num2;
            label3.Text ="Divide :" + total;



        }
    }
}
