using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstraction_two_account
{
    interface bank
    {
        string deposit(int acttype, int amt);
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
    }
    class saving :Account,bank
    {
        public string deposit(int accttype,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "call from saving account ,now current bal is :" + bal;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string str = b.deposit(2365, 500);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
