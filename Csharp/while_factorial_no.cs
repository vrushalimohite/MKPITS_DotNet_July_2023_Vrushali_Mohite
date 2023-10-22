using System;
namespace program
{
    class factorial
    {
        static void Main()
        {
            int fact = 1;
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                fact = fact * number;
                number --; 
            }
            Console.WriteLine("Factorial is=" + fact);
            Console.ReadKey();

        }
    }
}

