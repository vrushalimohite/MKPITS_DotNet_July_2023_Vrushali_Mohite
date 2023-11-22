using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_error_ex
{
    sealed class students
    {
       
    }
    class employe:students  //error show because students class is sealed .. 
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
