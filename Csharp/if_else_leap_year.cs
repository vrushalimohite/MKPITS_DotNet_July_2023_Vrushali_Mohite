using System;
namespace program
{
    class leap
    {
        static void Main()
        {
            int year;
            Console.WriteLine("Enetr year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine(+year+" "+"is Leap year");

            }
            else
            {
                Console.WriteLine(+year+" "+"is Not leap year");

            }
            Console.ReadKey();

        }
    }
}
