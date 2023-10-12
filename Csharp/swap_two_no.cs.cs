using System;
namespace program
{
    class swap
    {
        static void Main()
        {
            int num1=5, num2=6;
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("num1 =" + num1);
            Console.WriteLine("num2 =" + num2);

        }
    }
}
