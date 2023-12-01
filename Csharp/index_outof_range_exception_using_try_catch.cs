using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrangeexception_using_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 6 };
            try
            {
                for(int i=0; i<4;i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
