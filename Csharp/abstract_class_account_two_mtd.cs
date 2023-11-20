using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_class_act_two_mtd_one_without_mtd
{
    abstract class account
    {
        public int bal = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawal(int amount);
        public void showbalance()
        {
            Console.WriteLine("Balance is :" + bal);
        }
    }
    class saving : account
    {
        public override void deposit(int amount)
        {
            int intrest = 500;
            bal = bal + amount + intrest;
            Console.WriteLine("Balance with intrest :"+bal);
        }
        public override void withdrawal(int amount)
        {
            bal = bal - amount;
        }
    }
    class current : account
    {
        public override void deposit(int amount)
        {
            bal = bal + amount;
            Console.WriteLine("Balance without intrest :" + bal);

        }
        public override void withdrawal(int amount)
        {
            bal = bal - amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act = null;
            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Acount type saving or current");
            string acttype = Console.ReadLine();
            Console.WriteLine("Enter Acount type deposit or withdrawal");
            string at = Console.ReadLine();
            if(acttype=="saving")
            {
                act = new saving();
            }
            else if(acttype=="current")
            {
                act = new current();
            }
            if(at=="withdrawal")
            {
                act.withdrawal(amount);
            }
            else if(at=="deposit")
            {
                act.deposit(amount);
            }

            act.showbalance();
            Console.ReadKey();
        }
    }
}
