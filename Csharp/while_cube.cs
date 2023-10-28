using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube = 0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                cube = num * num;
                Console.WriteLine("cube of given number is :"+" "+cube);
                break;


            }



            Console.ReadKey();
        }
    }
}
