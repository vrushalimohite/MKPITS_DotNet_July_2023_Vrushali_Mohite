using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bank;

namespace WindowsForm_bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="saving")
            {
                act = new saving();
            }
            else if (comboBox1.Text=="current")
            {
                act = new current();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.withdrawal(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.showbalance();
            label4.Text = res;
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public abstract class account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string withdrawal(int amt)
        {
            string res = null;
            if (balance > amt)
            {
                res = "insufficient balance";
            }
            else
            {
                balance = balance - amt;
                res = "Amount Withdrawal successfully, now balance is :" + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount :" + balance.ToString();
        }
    }
    public class saving : account
    {
        public override string deposit(int amt)
        {
            int intrest = 500;
            balance = balance + amt + intrest;
            return "Amount deposited successfully ,balance is :" + balance.ToString();
        }

    }
    public class current : account
    {
        public override string deposit(int amt)
        {
            return "Amount deposited successfully,now balance is :" + balance.ToString();
        }
    }
}
*/