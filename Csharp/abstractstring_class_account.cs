using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_string_class_account
{
    abstract class Account
    {
        public int actno;
        public int bal = 1000;
        public abstract string deposit(int actno, int amt);
        public string showbalance()
        {
            return "Balance isn :" + bal;

        }
    }
    class current :Account
    {
        public override string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "amount deposited successfully without interest in current class";
        }
    }
    class saving:Account
    {
        public override string deposit(int actno, int amt)
        {
            this.actno = actno;
            int intrest = 200;
            bal = bal + amt + intrest;
            return "amount deposited successfully with interest in current class";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type (saving or currrent)");
            String acttype = Console.ReadLine();


            Account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            String res = act.deposit(actno, amt);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
