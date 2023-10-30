using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_marks_from_user_total_per_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int total = 0;
            float per = 0;
           for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter five subjects marks");
                num = Convert.ToInt32(Console.ReadLine());
                total += num;
            }
            Console.WriteLine(" five subjects total  marks ="+total);
            per = (total / 500.0f) * 100.0f;
            Console.WriteLine(" five subjects percentage =" + per);
            if(per>=75)
            {
                Console.WriteLine(" Grade =" + "Distinction");

            }
            else if(per<=75 && per>=60)
            {
                Console.WriteLine(" Grade =" + "First class");

            }
            else if(per>=60 && per<=40)
            {
                Console.WriteLine(" Grade =" + "Secound c class");

            }
            else
            {
                Console.WriteLine(" Grade =" + "Fail");

            }
            Console.ReadKey();
        }
    }
}
