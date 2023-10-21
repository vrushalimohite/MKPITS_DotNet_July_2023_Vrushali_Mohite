using System;
namespace program
{
    class even
    {
        static void Main()
        {
            int num = 20;
            while (num <= 30)
            {
                if (num % 2 == 1)
                    Console.WriteLine("Odd no is {0} ", num);
                num++;

            }
            Console.ReadKey();

        }
    }
}

