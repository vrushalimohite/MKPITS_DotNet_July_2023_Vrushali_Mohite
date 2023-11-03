using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_rectangle_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Width = Convert.ToInt32(textBox1.Text);
            rect.Height = Convert.ToInt32(textBox2.Text);
            rect.Area = rect.Width * rect.Height;

            StringBuilder sb = new StringBuilder();
           
            sb.Append("Area of rectangle :" +rect.Area);
            label3.Text = sb.ToString();
        }
    }
}
/* class code*/
/*namespace class_rectangle_forms
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area { get; set; }
    }
}*/