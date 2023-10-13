using System;
namespace program
{
    class no
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter no");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine(+num +" "+" No is Positive");

            }
            else
            {
                Console.WriteLine(+num +" "+" No is Negative");

            }
            Console.ReadKey();
        }
    }
}
