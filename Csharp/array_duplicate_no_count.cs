
// Write a C# Sharp program in to count duplicate elements in an array.


using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_duplicate_nos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int cnt = 0;
            Console.WriteLine("Enter five elements");
            for(int i=0;i<5;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" elements{0}={1}", i, num[i]);

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (num[i] == num[j])
                    {
                        cnt++;
                        break;
                    }
                }

            }
            Console.WriteLine("it is duplicate number :" + cnt);
            Console.ReadKey();




        }
    }
}
