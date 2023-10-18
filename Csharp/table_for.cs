using System;
namespace std
{
    class mul
    {
        static void Main()
        {


            int num, counter, result;
            Console.WriteLine("Enter no for print the table");
            num = Convert.ToInt32(Console.ReadLine());
            for (counter = 1; counter <= 10; counter++)
            {
                result = num * counter;
                Console.WriteLine("table is ==" + result);
            }
            Console.ReadKey();

        }
    }
}

