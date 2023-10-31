using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.getdata("vrushali", 23, "Nagpur");
            per.displaydata();
            Console.ReadKey();
        }
        class Person
        {
            string person_name;
            int age;
            String address;

            public void getdata(string name, int p_age, string p_address)
            {
                person_name = name;
                age = p_age;
                address = p_address;

            }
            public void displaydata()
            {
                Console.WriteLine("Person name :" + person_name);
                Console.WriteLine("Person Age :" + age);
                Console.WriteLine("Person Address :" + address);


            }
        }
    }
}
