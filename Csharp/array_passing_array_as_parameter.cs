using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_passing_array_as_parameter
{
    internal class Program
    {
        static void arrayparm(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];

                Console.WriteLine("sum of given no is :" + sum);
            }
        }

            static void Main(string[] args)

            {
                int[] num = { 22, 23, 25 };
                arrayparm(num);
                int[] num1 = { 55, 25, 55 };
                arrayparm(num1);

                Console.ReadKey();
            }
        }
    }
}
