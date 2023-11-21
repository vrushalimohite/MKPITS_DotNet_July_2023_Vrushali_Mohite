using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstraction_mtd_non_mtd
{
    interface Bank
    {
        string deposit(int actno, int amt);
        string withdrawl(int actno, int amt);
    }
    class Account
    {
        public int actno;
        
        public int bal = 1000;
    }
    class Saving:Account,Bank
    {
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Account No " + actno + "Balance is: " + bal;
        }
        public string withdrawl(int actno,int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "Account No "+ actno + "Balance is:" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b;
            b = new Saving();
            string str=b.deposit(123, 500);
            Console.WriteLine(str);
            Bank b1 = new Saving();             
             string str1=b1.withdrawl(234, 100);// output 900  different  object;

            
            
            //string str1=b.withdrwal(213,100)  output=1500-100=1400 same object

            Console.WriteLine(str1);
           
            Console.ReadKey();
        }
    }
}


