using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_odd_even_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("elements" + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i]%2==0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for(int i=0;i<j;i++)
            {
                Console.WriteLine("Even no :" + arr2[i]);
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Odd no :" + arr3[i]);

            }


            Console.ReadKey();


        }
    }
}
