﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder_class_used_append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Raj"+" ");
            sb.Append("Mukesh");
            Console.WriteLine(sb.ToString());
    
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
