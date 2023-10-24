using System;
namespace program
{
    class sum
    {
        static void Main()
        {
            int num=1, sum = 0;
            //Console.WriteLine("enter no");
            
            while(num<=7)
            {
                sum = sum + num;
                Console.WriteLine(num);
                num++;
                
            }
            Console.WriteLine("sum of no :" + sum);
            Console.ReadKey();
        }
    }
}
