using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_for_loop_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt;
            Console.WriteLine("Enter number");
            cnt = Convert.ToInt32(Console.ReadLine());
            for(num=1;num<=10;num++)
            {
                int res = cnt * num;
                Console.WriteLine("{0}*{1}={2}",cnt,num,res);
            }
            Console.ReadKey();
        }
    }
}
