
/*Bank Customer Class: Create a BankCustomer class with properties for CustomerName, AccountNumber, and Balance. 
 * Instantiate the BankCustomer class and simulate deposits and withdrawals from the customer's account. Display the final balance*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classback_deposit_withdrawals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int w = 0;
        int d = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Bank b = new Bank();
            b.name = textBox1.Text;
            b.accno = Convert.ToInt32(textBox2.Text);
            b.amount = Convert.ToInt32(textBox3.Text);
            b.deposit = Convert.ToInt32(textBox4.Text);
            b.withdrawals= Convert.ToInt32(textBox5.Text);
            d = b.amount + b.deposit;
            w = b.amount - b.withdrawals;
            StringBuilder sb = new StringBuilder();
            sb.Append("CustomerName :" + b.name+"\n");
            sb.Append(" AccountNumber :" + b.accno+"\n");
            sb.Append("Balance :" + b.amount+"\n");
            sb.Append("User Deposit Amount :" + b.deposit+"\n");

            sb.Append(" User withdrawals Amount :" + b.withdrawals+"\n");
            sb.Append(" " + "\n");
            sb.Append(" Current Balance After Deposit Amount :" + d+"\n");
            sb.Append("Current Balance After Withdrawals Amount :" + w+"\n");
            label6.Text = sb.ToString();



        }
    }
}
