using System;
namespace program
{
    class program
    {
        static void reference(ref int num)
        {
            num = 50;
            Console.WriteLine("num inside method :" + num);
        }
        static void Main()
        {
            int num = 100;
            reference(ref num);
            Console.WriteLine("num call directly reference value:" + num);

            Console.ReadKey();
        }
    }
}