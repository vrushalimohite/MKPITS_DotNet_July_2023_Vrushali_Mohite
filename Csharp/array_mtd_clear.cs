using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_mtd_clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 22, 23 };
            Array.Clear(arr,0,1); // variable name,null value,array size
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
