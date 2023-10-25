using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine(fact);
        }
            static void Main()
            {
                int number;
                Console.WriteLine("Enter number");
                number = Convert.ToInt32(Console.ReadLine());
                display(number);
            }

        
    }
}