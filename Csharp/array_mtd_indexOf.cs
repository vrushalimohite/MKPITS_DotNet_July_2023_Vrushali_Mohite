using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_mtd_indexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 23, 58, 55 };
            int l = Array.IndexOf(arr, 58);
            Console.WriteLine("index of 58 is :"+l);
            Console.ReadKey();
        }
    }
}
