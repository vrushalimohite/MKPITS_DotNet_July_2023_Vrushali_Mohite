using System;
namespace program
{
    class program
    {
        static int n=30;
        static void shared()
        {
            int num = 20;
            Console.WriteLine("num is inside method =" + num);
        }
        static void Main()
        {
            shared();
            Console.WriteLine("num is shared method =" + n);

            Console.ReadKey();
        }
    }
}