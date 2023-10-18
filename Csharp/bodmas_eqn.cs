using System;
namespace program
{
    class bodmas
    {
        static void Main()
        {
            int result;
            result = -1 + 4 * 6;
            Console.WriteLine("result is =" + result);
            result = (35 + 5) % 7;
            Console.WriteLine("result is =" + result);
            result = 14 + 4 * 6 / 11;
            Console.WriteLine("result is =" + result);
            result = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("result is =" + result);
            Console.ReadKey();

        }
    }
}
