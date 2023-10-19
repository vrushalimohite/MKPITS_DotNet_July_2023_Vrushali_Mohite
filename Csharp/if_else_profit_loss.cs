using System;
namespace program
{
    class profit
    {
        static void Main()
        {
            int s, c, res;
            Console.WriteLine("Enter cost price");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter selling price");
            s = Convert.ToInt32(Console.ReadLine());
            if(s>c)
            {
                res = s - c;
                Console.WriteLine("profit :"+res);
            }
            else
            {
                res = c - s;
                Console.WriteLine("loss;" + res);
            }



        }
    }
}
