﻿using System;
namespace program
{
    class divide
    {
        static void Main()
        {
            int num1, num2;
            float divide;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            divide = (float)num1 / (float)num2;
            Console.WriteLine("Result" + divide);
            Console.ReadKey();
        }
    }
}
