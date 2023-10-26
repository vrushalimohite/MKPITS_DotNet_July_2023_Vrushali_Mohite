using System;
namespace program
{
    class Mainclass
    {
        public static  int firstfactorial(int num)
        {
            int fact = 1;
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        static void Main()
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            int result = firstfactorial(number);
            Console.WriteLine("output :"+result);


            Console.ReadKey();

        }
    }
}
