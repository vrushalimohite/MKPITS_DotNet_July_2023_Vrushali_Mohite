using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_loop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 25, 45 };
            int sum = 0;
            foreach(int val in arr)
            {
                Console.WriteLine(val);
                sum += val;
            }
            Console.WriteLine("sum of given no is :" + sum);
            Console.ReadKey();
        }
    }
}
