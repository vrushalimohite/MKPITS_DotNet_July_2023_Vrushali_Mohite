using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_LOGIN
{
    public partial class FrmDetailscs : Form
    {
        public FrmDetailscs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label8.Text=numericUpDown1.Value.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append( dateTimePicker1.Text+"\n");
            sb.Append( dateTimePicker1.Value.ToShortDateString()+"\n");
            sb.Append(listBox1.SelectedItem.ToString()+"\n");
            sb.Append(maskedTextBox1.Text+"\n");
            sb.Append(monthCalendar1.SelectionStart.Date.ToShortDateString()+"\n");
            sb.Append(numericUpDown1.Value.ToString()+"\n");

            label3.Text = sb.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label3.Text = "Successful     ,Go to submit button";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
