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
    public partial class frmImageDetails : Form
    {
        public frmImageDetails()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<100;i++)
            {
                progressBar1.Value = i;
            }
            string imgname = comboBox1.Text;
            pictureBox2.Image = System.Drawing.Image.FromFile(imgname + ".jpg");


        }
    }
}
