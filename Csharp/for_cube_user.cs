using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cube_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;
            int num2;
            int cube = 0;
            int cube1 = 0;
            int cube2 = 0;
            for(int i=1;i<2;i++)
            {
                Console.WriteLine("Enter 3 nos");
                num = Convert.ToInt32(Console.ReadLine());
                num1 = Convert.ToInt32(Console.ReadLine());
                num2= Convert.ToInt32(Console.ReadLine());
                cube = num * num;
                cube1 = num1 * num1;
                cube2= num2 * num2;

            }
            Console.WriteLine("Cube :" + cube);
            Console.WriteLine("Cube :" + cube1);
            Console.WriteLine("Cube :" + cube2);
            Console.ReadKey();

        }
    }
}
