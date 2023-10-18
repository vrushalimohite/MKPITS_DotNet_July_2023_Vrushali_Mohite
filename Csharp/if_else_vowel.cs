
using System;
namespace program
{
    class vowel
    {
        static void Main()
        {
            char ch;
            Console.WriteLine("Enter vowel");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' 
                || ch == 'u' || ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U') 
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("It is not vowel");

            }
            Console.ReadKey();
        }
    }

}
