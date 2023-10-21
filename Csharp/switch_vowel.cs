using System;
namespace program
{
    class vowel
    {
        static void Main()
        {
            char op;
            Console.WriteLine("Enter character");
            op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                Console.WriteLine("it is Vowel");
                    break;
                default:
                    Console.WriteLine("It is not Vowel");
                    break;


            }
            Console.ReadKey();
        }
    }
}
