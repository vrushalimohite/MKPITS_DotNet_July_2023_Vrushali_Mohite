using System;
namespace program
{
    class age
    {
        static void Main()
        {
            int age;
            Console.WriteLine("enter Age");
                age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else
            {
                Console.WriteLine("Not elgible  for vote");
            }
            Console.ReadKey();

        }
    }
}
