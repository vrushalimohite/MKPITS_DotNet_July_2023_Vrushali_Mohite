using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_typing_master
{
    public partial class Frmtyping : Form
    {
        string[] sentences = { "Cloud computing is the on-demand delivery of IT resources over the Internet" +
                " with pay-as-you-go pricing. Instead of buying, owning, and maintaining physical data centers" +
                " and servers, you can access technology services, such as computing power, storage, " +
                "and databases, on an as-needed basis from a cloud provider like Amazon Web Services (AWS)." };
        Random R = new Random();
        public Frmtyping()
        {
            InitializeComponent();
            richTextBox1.Text = sentences[R.Next(0, sentences.Length)];
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string s=textBox1.Text;

            int t = s.Length;
            int total = 77;
            label1.Text = total.ToString();

        }
    }
}
