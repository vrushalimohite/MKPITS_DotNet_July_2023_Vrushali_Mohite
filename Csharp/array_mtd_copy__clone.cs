using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_mtd_clone_Copy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 22, 23 };
            int[] arr1 = new int[3];
            Array.Copy(arr, arr1, 3);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
