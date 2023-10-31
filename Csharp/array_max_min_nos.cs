using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_max_min_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter three nos");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = num[0], min = num[0];
            for (int i = 0; i < 3; i++)
            {
                if (num[i]>max)
                {
                    max = num[i];
                }
                if (num[i]<min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine("Maximum element is :" + max);
            Console.WriteLine("Minimum element is :" + min);
            Console.ReadKey();

        }
    }
}
