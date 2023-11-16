using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_mtd_access_mpdifier_protected
{
    public class person
    {
        string name;
        string address;
        protected  internal void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected  internal void displaypersondata()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address :" + address);
        }
    }
    public class students : person
    {
        int rno;
        int marks;
        public void getstudentsdata(int rno, int marks)
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
            s.getpersondata("rajesh", "Nagpur");
            s.displaypersondata();
            s.getstudentsdata(14, 99);
            s.displaystudentsdata();
            Console.ReadKey();
        }
    }
}
