/*Circle Class: Create a Circle class with a property for Radius.
 * Implement methods to calculate the circumference and area of the
 * circle. Instantiate the Circle class and compute both the
 * circumference and area for a circle with a radius of 7 units.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_circle_area_circ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle();
           
            //Console.WriteLine("Enter radius");
            cir.Radius = Convert.ToInt32(textBox1.Text);
            cir.Area =3.14f*cir.Radius * cir.Radius;
            cir.Circ = 2 * 3.14f * cir.Radius;
            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Circle :" + cir.Area + "\n");
            sb.Append("Circumference of Circle :" + cir.Circ + "\n");
            label2.Text = sb.ToString();

        }
    }
}
/* class code*/
/*public int Radius { get; set; }
public float Area { get; set; }
public float Circ { get; set; }*/