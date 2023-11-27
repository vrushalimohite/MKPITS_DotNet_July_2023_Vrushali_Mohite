using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            nums.AddLast(1);
            nums.AddLast(2);
            nums.AddLast(5);
            LinkedListNode<int> node = nums.Find(2);
            nums.AddBefore(node, 7);
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
