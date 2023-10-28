
using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[,] num1 = { { 2, 5 }, { 8, 6 } };
            int[,] num2 = { { 7, 4 }, { 3, 5 } };
            int[,] trans = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {

                for (int col = 0; col < 2; col++)
                {
                    trans[row, col] = num1[col, row] + num2[row, col];
                }

            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(trans[row, col] + "\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
