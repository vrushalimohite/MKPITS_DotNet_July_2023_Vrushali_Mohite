using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_square_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square = 0;
            char choice = 'y';
            do
            {
                Console.WriteLine("Enter number");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("Square ="+ square);
                Console.WriteLine("Do you want continue press y and n");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice == 'y' || choice == 'n');
            Console.ReadKey();
        }
    }
}
