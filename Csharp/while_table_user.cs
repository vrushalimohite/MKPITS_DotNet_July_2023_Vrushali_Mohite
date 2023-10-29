using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int cnt = 1;
            while(cnt<=10)
            {
                int result = num * cnt;

                Console.WriteLine("{0}*{1}={2}",num,cnt,result);
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
