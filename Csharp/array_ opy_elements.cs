// Write a C# Sharp program to copy the elements of one array into another array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 10, 12 };
            int[] arr1 = new int[3];
            Array.Copy(arr,arr1,3);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine();

                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
