using System;
namespace program
{
    class sum
    {
        static void Main()
        {
            int no = 1;
            int sum = 0;
            while(no<=10)
            {
                
                sum = sum + no;
                Console.WriteLine(no);
                
                Console.WriteLine("sum of 10 prime  no :"+sum);
                no++;
            }

        }
    }
}

