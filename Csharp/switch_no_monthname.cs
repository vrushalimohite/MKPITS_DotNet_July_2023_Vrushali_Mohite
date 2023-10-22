using System;
namespace program
{
    class number
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter Month Number");
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("28/29");
                    break;


                case 3:
                    Console.WriteLine("31 days");
                    break;

                case 4:
                    Console.WriteLine("30 days");
                    break;

                case 5:
                    Console.WriteLine("31 days");
                    break;
                case 6:
                    Console.WriteLine("30 days");
                    break;
                case 7:
                    Console.WriteLine("31 days");
                    break;
                case 8:
                    Console.WriteLine("31");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("31");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("31");
                    break;
                default:
                    Console.WriteLine("invalid month number");
                    break;


            }
            Console.ReadKey();
        }
    }
}


