using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_sum_of_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int num;

            for (int i = 1; i <= 5; i++)
            {

                Console.WriteLine("Enter five number");


                num = Convert.ToInt32(Console.ReadLine());

                
                    sum = sum + num;



            }
            Console.WriteLine("Sum of five number =" + sum);



            Console.ReadKey();
        }
    }
}
