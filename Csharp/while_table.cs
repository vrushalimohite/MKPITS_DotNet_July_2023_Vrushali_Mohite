using System;
namespace program
{
    class table
    {
        static void Main()
        {
            int num;
            
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
             int Result = 0;
            int counter = 1;

            while(counter<=10)
            {
                Result = num * counter;
                Console.WriteLine("{0}*{1}={2}", num, counter, Result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
