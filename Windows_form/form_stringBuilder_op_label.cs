﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            StringBuilder sb = new StringBuilder();
            int res = 1;
            int cnt;
            int num = Convert.ToInt32(textBox1.Text);
            for(cnt=1;cnt<=10;cnt++)
            {
                res = num * cnt;
                sb.Append(num + "*" + cnt + "=" + res + "\n");

            }
            label2.Text = sb.ToString();

        }
    }
}
