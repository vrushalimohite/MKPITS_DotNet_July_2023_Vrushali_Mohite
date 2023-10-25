using System;
namespace program
{
    class program
    {
        static int display(int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;

            }
            return fact;
        }
        static void Main()
        {
            int number;
            Console.WriteLine("Enter number");
            number= Convert.ToInt32(Console.ReadLine());

            int res = display(number);
            Console.WriteLine("Factorial is :" + res);
        }
    }
}