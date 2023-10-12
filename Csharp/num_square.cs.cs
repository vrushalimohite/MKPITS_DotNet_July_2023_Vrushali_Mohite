using System;
namespace squareprogram
{
    class program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square" + square);
            Console.ReadKey();
        }
    }
}
