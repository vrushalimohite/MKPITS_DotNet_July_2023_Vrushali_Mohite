using System;
namespace program
{
    class triangle
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter triangles of angles values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("<a" + a + " " + "<b" + b + " " + "<c" + c);
            if (a == b && b == c && c == a)
            {
                Console.WriteLine("This is an Equilateral Triangle");

            }
            else if (a != b && b == c && c != a)

            {
                Console.WriteLine("This is an Equilateral Triangle");

            }
            else if (a != b && b != c && c != a)
            {
                Console.WriteLine("This is an Scalence Triangle");

            }

            Console.ReadKey();

        }
    }
}

