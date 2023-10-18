using System;
namespace program
{
    class temp
    {
        static void Main()
        {
            int temp;
            Console.WriteLine("Enter  temperature");
            temp = Convert.ToInt32(Console.ReadLine());

            if(temp<=0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>=0 && temp<=20)
            {
                Console.WriteLine("Cold");

            }
            else if(temp>=20 && temp<30)
            {
                Console.WriteLine("Normal");

            }
            else
            {
                Console.WriteLine("Very Hot");

            }
            Console.ReadKey();

        }
    }
}
﻿



