using System;
namespace program
{
    class quadrent
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("Enter x and y value");
            x = Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());
            if(x>0&&y>0)
            {
                Console.WriteLine("The coordinates point" + (x, y) + "" + "lies on First quadrent");
            }
            else if(x>0&&y<0)
            {
                Console.WriteLine("The coordinates point" + (x, y) + "" + "lies on Second quadrent");

            }
            else if(x<0&&y<0)
            {
                Console.WriteLine("The coordinates point" + (x, y) + "" + "lies on Third quadrent");

            }
            else if(x<0&&y>0)
            {
                Console.WriteLine("The coordinates point" + (x, y) + "" + "lies on Fourth quadrent");

            }
            Console.ReadKey();
        }
    }
}
