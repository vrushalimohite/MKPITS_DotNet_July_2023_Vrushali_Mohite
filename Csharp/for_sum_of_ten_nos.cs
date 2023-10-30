using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sum_of_ten_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
               
                sum =sum+num;
            }
            Console.WriteLine("Sum of ten no is :" + sum);

            Console.ReadKey();
        }
    }
}
