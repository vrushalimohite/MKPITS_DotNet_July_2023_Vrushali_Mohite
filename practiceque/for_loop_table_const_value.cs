using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_for_loop_table_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cnt = 8;
            for(num=1;num<=10;num++)
            {
                int res = cnt * num;
                Console.WriteLine("{0}*{1}={2}",cnt,num,res);
            }
            Console.ReadKey();
        }
    }
}
