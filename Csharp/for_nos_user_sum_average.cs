using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_nos_from_user_sum_avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            float avg = 0;
            for(int i=0; i<10;i++)
            {
                Console.WriteLine("Enter 10 numbers");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine();
            Console.WriteLine("Sum of ten nos :" + sum);
            avg = sum / 10;
            Console.WriteLine("Average of Ten no is :" + avg);
            Console.ReadKey();
        }
    }
}
