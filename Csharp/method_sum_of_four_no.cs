using System;
namespace program
{
    class program
    {
        static void sum()
        {
           int num = 1;
            int sum = 0;
            while(num<=4)
            {
                sum = sum + num;
                num++;
            }
            Console.WriteLine("Sum of the digit of the no 1234 is:" + sum);


        }
        static void Main()
        {
            sum();
        }
    }
}