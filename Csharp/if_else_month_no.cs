using System;
namespace program
{
    class numbers
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter Month no");
            num = Convert.ToInt32(Console.ReadLine());




            if (num == 1)
            {
                Console.WriteLine("31 day");
            }
            else if (num == 2)
            {
                Console.WriteLine("28 or 29 days");

            }
            else if (num == 3)
            {
                Console.WriteLine("31 day");

            }
            else if (num == 4)
            {
                Console.WriteLine("30 day");

            }
            else if (num == 5)
            {
                Console.WriteLine("31 day");

            }
            else if (num == 6)
            {
                Console.WriteLine("30 day");

            }
            else if (num == 7)
            {
                Console.WriteLine("31 day");

            }
            else if (num == 8)
            {
                Console.WriteLine("31 day");

            }
            else if (num == 9)
            {
                Console.WriteLine("30 day");

            }
            else if (num == 10)
            {
                Console.WriteLine("31 day");

            }
            else if(num==11)
            {
                Console.WriteLine("30 day");

            }
            else if(num==12)
            {
                Console.WriteLine("31 day");

            }

        
            Console.ReadKey();
        }
    }
}



