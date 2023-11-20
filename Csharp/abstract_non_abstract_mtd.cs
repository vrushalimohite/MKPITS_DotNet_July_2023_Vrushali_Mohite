using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_non_abstract_mtd
{
    abstract class account
    {
        public abstract void deposit();  //abstract mtd
            public void showbalance()   //non abstract mtd
        {
            Console.WriteLine("abstract and non abstract mtd");
        }
    }
    class saving : account
    {
      public override void deposit()
        {
            Console.WriteLine("call from saving account ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act = new saving();
            act.deposit();
            act.showbalance();
            Console.ReadKey();
        }
    }
}
