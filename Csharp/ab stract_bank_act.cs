using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_bank_act
{
    abstract class account
    {
        public abstract void deposit();
        

        
    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("hello from saving deposit mtd");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act = new saving();
            act.deposit();
            Console.ReadKey();
        }
    }
}
