using System;
namespace program
{
    class designation
    {
        static void Main()
        {
            int bonus = 0;
            string designation;
            Console.WriteLine("Enter  designation");
            designation = (Console.ReadLine());
            switch(designation)
            {
                case "maneger":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 1000;
                    break;
                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }
            Console.WriteLine("{0}", bonus);

            Console.ReadKey();

        }
    }
}
