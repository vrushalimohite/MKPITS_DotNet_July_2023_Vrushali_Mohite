using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructer_class_book_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b1 = new Book(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox4.Text, Convert.ToInt32(textBox3.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("Bookid :" + b1.bookid + "\n");
            sb.Append("Book title : " + b1.title+ "\n");
            sb.Append("Book Author : " + b1.author+ "\n");
            sb.Append("Book price : " + b1.price + "\n");

            label6.Text = sb.ToString();
           
        }
    }
}
/* class code */
/* internal class Book
    {
        public int bookid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int price { get; set; }

        public Book (int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
    }*/