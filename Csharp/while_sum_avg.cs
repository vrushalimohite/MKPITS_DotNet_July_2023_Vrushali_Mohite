//4. Write a C# Sharp program to read 10 numbers and find their average and sum.
using System;
namespace program
{
    class sum
    {
        static void Main()
        {
            int num = 1, sum = 0;
            float avg = 0;
            while (num <= 10)
            {
                sum = sum + num;
                avg = sum / 10.0f;
                Console.WriteLine(num);
                num++;
                
            }
            Console.WriteLine();
            Console.WriteLine("Sum of 10 prime no is :" + sum);

            Console.WriteLine("Average :" + avg);
            Console.ReadKey();

        }
    }
}
