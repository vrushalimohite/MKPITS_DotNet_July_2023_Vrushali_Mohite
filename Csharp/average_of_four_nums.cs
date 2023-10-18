//average of four no.


using System;
namespace program
{
    class average
    {
        static void Main()
        {
            int num1 = 10, num2 = 15, num3 = 20, num4 = 30;
            float Average;

            Console.WriteLine("Enter four no");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            Average =(float)num1 + (float)num2 + (float)num3 + (float)num4 / 4;
            Console.WriteLine("Average of num :" + Average);
            Console.ReadKey();
        }
    }
}
