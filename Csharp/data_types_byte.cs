using System;
namespace std
{
    class data_types
    {
        static void Main()
        {
            byte a;
            Console.WriteLine("Enter number");
            a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte is :" + a);
            Console.ReadKey();
        }
    }
}
