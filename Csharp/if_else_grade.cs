using System;
namespace program
{
    class grade
    {
        static void Main()
        {
            string grade, a,A,v,V,g,G,e,E,f,F;
            Console.WriteLine("Enter Grade,E,V,G,A,F");
            grade =Convert.ToString(Console.ReadLine());
            A = Convert.ToString(Console.ReadLine());
            a = Convert.ToString(Console.ReadLine());
            v = (Console.ReadLine());
            V = (Console.ReadLine());
            g = (Console.ReadLine());
            G = (Console.ReadLine());
            f = (Console.ReadLine());
            F = (Console.ReadLine());
            e = (Console.ReadLine());
            E = (Console.ReadLine());



            if (grade==A && grade==a)
            {
                Console.WriteLine("Average");
            }
            else if (grade == E && grade == e)
            {
                Console.WriteLine("Excellent");

            }
           else if (grade == v && grade == V)
            {
                Console.WriteLine("Very good");

            }
            else if (grade == G && grade == g)
            {
                Console.WriteLine("Good");

            }
           else if (grade == F && grade == f)
            {
                Console.WriteLine("Fail");

            }
            Console.ReadKey();
        }
    }
}
