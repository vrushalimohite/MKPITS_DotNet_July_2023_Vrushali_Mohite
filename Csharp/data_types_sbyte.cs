using System;
namespace program
{
    class datatypes
    {
        static void Main()
        {
            sbyte b;
            Console.WriteLine("Enter number");
            b = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte is :" + b);
            Console.ReadKey();
        }
    }
}
