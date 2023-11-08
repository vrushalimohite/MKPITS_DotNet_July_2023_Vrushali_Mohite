/*wap to accept a number and print square and then ask the user "whether you want ot continue or not "
 * , if user press y then ask for another number other wise exit the program using do while loop*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice = 'y';

            do
            {
                Console.WriteLine("Enter number");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("square={0}", square);
                Console.WriteLine("Continue for next press y and n");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice=='y'|| choice=='n');
            Console.ReadKey();

        }
    }
}