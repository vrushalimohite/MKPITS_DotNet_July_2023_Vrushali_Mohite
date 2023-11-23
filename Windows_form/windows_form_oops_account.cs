using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms_oops_account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if(tt=="saving")
            {
                act = new saving();
            }
            else if(tt=="current")
            {
                act = new current();
            }
            label4.Text = act.deposit(actno, amt);
            label5.Text = act.showbalance();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if (tt == "saving")
            {
                act = new saving();
            }
            else if (tt == "current")
            {
                act = new current();
            }
            label4.Text = act.withdrawal(actno, amt);
            label5.Text = act.showbalance();
        }
    }
}
/*
 namespace windows_forms_oops_account
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract string deposit(int actno, int amt);
        public abstract string withdrawal(int actno, int amt);

        public string showbalance()
        {
            return "bal is :" + bal;
        }
    }
    class saving :Account
    {
        public override string deposit(int actno, int amt)
        {
            int intrest = 500;
            bal = bal + intrest + amt;
            return "bal is :" + bal;
        }
        public override string withdrawal(int actno, int amt)
        {
            bal = bal - amt;
            return "bal is : " + bal;
        }
    }
    class current :Account
    {
        public override string deposit(int actno, int amt)
        {
            bal = bal + amt;
            return "bal is :" + bal;
        }
        public override string withdrawal(int actno, int amt)
        {
            bal = bal - amt;
            return "bal is " + bal;
        }
    }
}
 */
