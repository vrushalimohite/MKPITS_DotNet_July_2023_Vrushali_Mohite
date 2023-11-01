using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_per_attributes_method_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person_o p = new person_o();
            p.name = textBox1.Text;
            p.age = Convert.ToInt32(textBox2.Text);
            p.address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Name :" + p.name + "\n");
            sb.Append("Age :" + p.age + "\n");
            sb.Append("Address:" + p.address + "\n");
            label4.Text = sb.ToString();

        }
    }
}

/*code*/
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_per_attributes_method_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person_o p = new person_o();
            p.name = textBox1.Text;
            p.age = Convert.ToInt32(textBox2.Text);
            p.address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Name :" + p.name + "\n");
            sb.Append("Age :" + p.age + "\n");
            sb.Append("Address:" + p.address + "\n");
            label4.Text = sb.ToString();

        }
    }
}
/*class code */
class Person
{
    public string name;
    public int age;
    public string address;
    public void getdata(string name,int age,string address)
    {
        this.name=name;
        this.age=age;
        this.address=address;
    }
}
