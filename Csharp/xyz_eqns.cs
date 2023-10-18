using System;
namespace program
{
    class eqn
    {
        static void Main()
        {

            int x, y, z, result1,result2;
            Console.WriteLine("Enter x,y,z values");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            result1 = (x + y) * z;
            Console.WriteLine("result1 is=" + result1);
            result2 = (x * y )+(y * z);
            Console.WriteLine("result2 is=" + result2);
            Console.ReadKey();

        }
     
    }
}
