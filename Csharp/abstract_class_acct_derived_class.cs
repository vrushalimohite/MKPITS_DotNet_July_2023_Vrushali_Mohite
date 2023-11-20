using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_acct_derived_class
{
    abstract class account

    {
        public int bal = 1000;
        public int actno;
        public abstract void deposit(int amt);
        public void showbalance()
        {
            Console.WriteLine("call from account {0},{1}", actno, bal);
        }
    }
    class current: account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
        }

    }
    class saving : account
    {
        public override void deposit(int amt)
        {
            int intrest = 200;
            bal = bal + amt + intrest;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deposit amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter acoount type saving or current");
            string acttype = Console.ReadLine();
            account act = null;
            if(acttype=="saving")
            {
                act = new saving();
            }
            else if(acttype=="current")
            {
                act = new current();
            }
            act.actno = actno;
            act.deposit(amt);
            act.showbalance();

            Console.ReadKey();

        }
    }
}
