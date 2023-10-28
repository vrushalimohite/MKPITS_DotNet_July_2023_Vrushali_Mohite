using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[,] num1 = { { 2, 5 }, { 8, 6 } }; //matrix 1
            int[,] num2 = { { 3, 4 }, { 2, 6 } }; //matric 2
            int[,] sum = new int[2, 2]; //2 row 2 col (3 matrix)
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    sum[row, col] = num1[row, col] * num2[row, col];
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {

                    Console.Write(sum[row, col] + "\t");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("multiplication of two matrix by using 2 d array");

            Console.ReadKey();

        }
    }
}
