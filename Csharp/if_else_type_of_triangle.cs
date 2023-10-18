using System;
namespace program
{
    class triangle
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter angles of triangles <a,<b,<c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c= Convert.ToInt32(Console.ReadLine());

            if (a==b && b==c)
            {
                Console.WriteLine("This is an E Triangle");
            }
            else if(a==b || b==c || c==a )
            {
                Console.WriteLine("This is an T Triangle");

            }
            else
            {
                Console.WriteLine("This is an Scalence Triangle");

            }
            Console.ReadKey();

        }
    }
}
