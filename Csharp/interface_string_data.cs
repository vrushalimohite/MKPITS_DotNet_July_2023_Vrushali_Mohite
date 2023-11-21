using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstraction_string_data
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposit succesfully now bal is :" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = new saving();
            string res = b.deposit(3254, 500);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
