using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_book_title_author_pyear_display_each_book_details_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book[] bk = new Book[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            bk[0] = new Book();
            bk[1] = new Book();
            bk[2] = new Book();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bk[cnt].Title = (textBox1.Text);
            bk[cnt].Author = textBox2.Text;
            bk[cnt].Publicationyear = (textBox3.Text);
            cnt++;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            if(cnt==3)
            {
                button1.Enabled = false;
                textBox1.Enabled=false;
                textBox2.Enabled=false;
                textBox3.Enabled=false;
                button2.Enabled = true;
                MessageBox.Show("All Book details Available ...Please press Details Button");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book details available here.."+"\n");
            sb.Append(" "+"\n");
            sb.Append("..Thank you for Visit.."+"\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("------------------------------ "+"\n");
                sb.Append(" "+"\n");

                sb.Append("Book Title :-" + bk[i].Title + "\n");
                sb.Append("Book Author :-" + bk[i].Author + "\n");
                sb.Append("Book Publish Year :-" + bk[i].Publicationyear + "\n");
                sb.Append("------------------------------ "+"\n");
                sb.Append(" ");
                label4.Text = sb.ToString();

            }


        }
    }
}
