using System;
namespace program
{
    class dayno
    {
        static void Main()
        {
            int dayno;
            Console.WriteLine("Enter no between 1 to7");
            dayno = Convert.ToInt32(Console.ReadLine);
            switch(dayno)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thesday");
                    break;
                case 3:
                    Console.WriteLine("Wensday");
                    break;

                case 4:
                    Console.WriteLine("thresday");
                    break;


                case 5:
                    Console.WriteLine("friaday");
                    break;

                case 6:
                    Console.WriteLine("satuerday");
                    break;

                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid day no");
                    break;


            }
        }
    }
}
