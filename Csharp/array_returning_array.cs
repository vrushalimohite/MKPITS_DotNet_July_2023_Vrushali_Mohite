using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_returning_array
{
    internal class Program
    {
      static int[] returnarry()
        {
            int[] arr = { 22, 23, 21 };
            return arr;
        }
        static void Main()
        {
            int[] res = returnarry();
            for(int i=0;i<res.Length;i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
