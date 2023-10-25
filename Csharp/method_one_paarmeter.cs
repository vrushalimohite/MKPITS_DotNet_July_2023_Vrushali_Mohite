using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial is :"+fact);


        }
        static void Main()
        {
            display(5);
        }
    }
}