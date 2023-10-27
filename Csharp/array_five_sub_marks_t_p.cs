//program to accept 5 subject marks in an array then display total, percentage and grade
using System;
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int total= 0;
            float per = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 5 subject marks ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                total= total + marks[i];
                per = (total / 500.0f) * 100.0f;
            }
            Console.WriteLine("Total :" + total);
            Console.WriteLine();

            Console.WriteLine("percentage : " + per);


            Console.ReadKey();

        }
    }
}
