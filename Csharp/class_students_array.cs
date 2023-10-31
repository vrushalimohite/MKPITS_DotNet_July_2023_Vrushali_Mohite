using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_students_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students stud = new Students();


            Console.WriteLine("Enter roll no and name");
            int roll_no = Convert.ToInt32(Console.ReadLine());

            string n = (Console.ReadLine());

            int[] marks = new int[5];

            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Enter Five subject marks");
                marks[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            stud.getdata(n, roll_no, marks);
            stud.displaydata();
            Console.ReadKey();

        }
        class Students
        {
            string name;
            int roll_no;
            int[] subjectmarks;
            int total = 0;

            public void getdata(string name, int roll_no, int[] marks)
            {
                this.name = name;
                this.roll_no = roll_no;
                this.subjectmarks = marks;

            }
            public void displaydata()
            {

                Console.WriteLine("Students name :" + name);
                Console.WriteLine("Students roll no :" + roll_no);
                for (int i = 0; i < subjectmarks.Length; i++)
                {
                    total = total + subjectmarks[i];
                }    


                    int avg = total / subjectmarks.Length;

                    Console.WriteLine("Average :" + avg);

                
            }
        }
    }
}
