//program to accept 3 character in an array.
using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            char[] ch = new char[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter 3 charcter");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.Write("{0}", ch[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
