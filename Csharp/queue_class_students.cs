using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_class_students
{
    class students
    {
        public int id;
        public string name;
        public students(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s1 = new students(123, "Rajesh");
            students s2 = new students(321, "kamlesh");

            Queue q = new Queue();
            q.Enqueue(s1);
            q.Enqueue(s2);
            foreach(students val in q)
            {
                Console.WriteLine("ID :" + val.id);
                Console.WriteLine("Name :" + val.name);
            }
            students r = (students)q.Dequeue();
            Console.WriteLine("item :" + r.id + " " + r.name);
            Console.WriteLine("After queue");
            foreach(students val in q)
            {
                Console.WriteLine("name :" + val.name);
            }
            Console.ReadLine();
        }
    }
}
