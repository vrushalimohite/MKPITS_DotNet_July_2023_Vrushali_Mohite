using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_no_dayno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayno;
            dayno = Convert.ToInt32(textBox1.Text);
            switch (dayno)
            {
                case 1:
                    label2.Text = "Monday";
                    break;
                case 2:
                    label2.Text = "Tuesday";
                    break;
                case 3:
                    label2.Text = "Wednesday";
                    break;
                case 4:
                    label2.Text = "Thursdat";
                    break;
                case 5:
                    label2.Text = "Friaday";
                    break;
                case 6:
                    label2.Text ="Saturday";
                    break;
                case 7:
                    label2.Text = "Sunday";
                        break;
                default:
                    label2.Text = "Invalid Day No";
                    break;
            }
           
        }
    }
}
