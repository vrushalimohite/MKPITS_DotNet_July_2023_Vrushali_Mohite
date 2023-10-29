using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int cnt = 1; cnt <= 10; cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0}*{1}={2}",num,cnt,result);
            }
            Console.ReadKey();
        }
    }
}
