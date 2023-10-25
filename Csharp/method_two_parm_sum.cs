using System;
namespace program
{
    class program
    {
        static void display(int num1,int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Sum of two no is :" + sum);
        }
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            display(num1, num2);
            Console.ReadKey();
        }
    }
}