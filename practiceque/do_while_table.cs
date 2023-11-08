using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_print_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int on = 1;
            int tn = 2;
            int res, res1;
            int cnt = 1;
            do
            {
                res = on *cnt;
                res1 = tn * cnt;

                Console.WriteLine("{0}*{1}={2}", on, cnt, res+"\n");

                Console.WriteLine("{0}*{1}={2}", tn, cnt, res1);
                Console.WriteLine("\t");

                cnt++;

                //Console.WriteLine(" ");
            }
            while (cnt <= 10);
            Console.ReadKey();
        }
    }
}
