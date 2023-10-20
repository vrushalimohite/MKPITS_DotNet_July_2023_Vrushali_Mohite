using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_height_centimeter
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
            int height;
            height = Convert.ToInt32(textBox1.Text);
            if(height>=150)
            {
                label2.Text = "It Is Not Dwarf";
            }
            else
            {
                label2.Text = "It is Dwarf";
            }
        }
    }
}
