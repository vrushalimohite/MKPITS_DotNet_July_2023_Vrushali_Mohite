using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_mtd_class_getdata_displaydata
{
    public class person
    {
        public string name;
        public string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address :" + address);
        }
    }
    public class students : person
    {
        public int rno;
        public int marks;
        public void getstudentsdata(int rno,int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentsdata()
        {
            Console.WriteLine("Roll no :" + rno);
            Console.WriteLine("Marks :" + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            s.getpersondata("Rajesh", "Nagpur");
            s.displaypersondata();
            s.getstudentsdata(12, 90);
            s.displaystudentsdata();
            Console.ReadKey();
        }
    }
}
