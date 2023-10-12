using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int radius;
            float area, cicr;

            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            cicr = 2 * 3.14f * radius;
            Console.WriteLine("area=" + area);
            Console.WriteLine("circumfarance =" + cicr);

        }
    }
}