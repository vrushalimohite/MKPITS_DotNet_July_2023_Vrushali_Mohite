
/*Interface Declaration:

Create an interface named ILogger with two methods: LogMessage(string message) and LogError(string errorMessage).
Implement a class called ConsoleLogger that implements the ILogger interface and prints messages and errors to the 
console.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ass_que_1
{
    interface Logger
    {
        string Logmessage(string message);
        string LogError(string error_message);
    }
    class consolelogger : Logger
    {
        
        public string Logmessage(string message)
        {
            
            return "call from Logmessage :" + message;
        }
        public string LogError(string error_message )
        {
         
            return "call from Logerror :" + error_message;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            consolelogger c = new consolelogger();
            string str = c.Logmessage("message");
            string res = c.LogError("error message");
            Console.WriteLine(str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
