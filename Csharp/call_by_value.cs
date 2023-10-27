using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            num = 5;
            Console.WriteLine("num inside method :" + num);
        }
        static void Main()
        {
            int num = 3;
            display(num);
            Console.WriteLine("num  after passing inside main :" + num);
            Console.ReadKey();
        }
    }
}