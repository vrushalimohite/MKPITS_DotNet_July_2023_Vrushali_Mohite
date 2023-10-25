using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            int cnt;
            int res = 1;

            for (cnt = 1; cnt <= 10; cnt++)
            {
                
                res = cnt * num;
                Console.WriteLine(res);


            }

        }
        static void Main()
        {
            display(5);
        }
    }
}