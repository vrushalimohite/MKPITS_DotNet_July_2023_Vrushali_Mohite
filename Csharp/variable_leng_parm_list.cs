using System;
namespace program
{
    class program
    {
        static int calculate(params int[] jd)
        {
            int total, i = 0;
            for (i = 0,total=0; i < jd.Length; i++) 
            {
                total = total + jd[i];
            }
            return total;
        }
        static void Main()
        {
            int result = calculate(21, 22);
            Console.WriteLine("total :" + result);
            Console.ReadKey();
        }
    }
}