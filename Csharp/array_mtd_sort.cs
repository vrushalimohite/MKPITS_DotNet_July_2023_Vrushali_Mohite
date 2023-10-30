using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_mtd_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 22, 23 };
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
