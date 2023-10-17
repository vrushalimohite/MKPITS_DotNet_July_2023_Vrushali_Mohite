using System;
namespace program
{
    class equation
    {
        static void Main()
        {
            int a,b,c;
            float total;
            Console.WriteLine("Enetr a value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr b value");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr c value");
            c= Convert.ToInt32(Console.ReadLine());
            total = (b * b) - 2 * a * c;
            Console.WriteLine("result:" + total);
            if (total!=0)
            {
                Console.WriteLine("It is imaginary root");

            }
            else
            {
                Console.WriteLine("It is real root");

            }
            Console.ReadKey();






        }
    }
}

