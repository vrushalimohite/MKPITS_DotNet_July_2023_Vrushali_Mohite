using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt;
            int num, a = 0;
            
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (cnt = 2; cnt>0 ; cnt++)
            {
                a++;
            }
                if (a == 0)
                {

                    Console.WriteLine(" Given number is prime");
                    

                }
               else if(a!=0)
                {
                    Console.WriteLine(" Given number is not  prime");

                }
              

            Console.ReadKey();
        }
    }
}
