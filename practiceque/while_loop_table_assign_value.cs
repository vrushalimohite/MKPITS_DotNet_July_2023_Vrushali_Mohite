using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_while_loop_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int cnt = 9;
            //Console.WriteLine("Enter number");
            //cnt = Convert.ToInt32(Console.ReadLine());
            while (num <= 10)
            {
                int res = cnt * num;
                Console.WriteLine("{0}*{1}={2}",cnt,num,res);
                num++;
            }
            Console.ReadKey();
        }
    }
}
