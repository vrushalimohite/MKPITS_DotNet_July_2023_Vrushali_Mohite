/*
 Default Interface Method:

Extend the ILogger interface from the first question by adding a default method LogInfo(string infoMessage) that logs informational messages.
Implement the ConsoleLogger class to support the new LogInfo method.

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
        string LogInfo(string infoMessage);
    }
    class consolelogger : Logger
    {

        public string Logmessage(string message)
        {

            return "call from Logmessage :" + message;
        }
        public string LogError(string error_message)
        {

            return "call from Logerror :" + error_message;

        }
        public string LogInfo(string infomessage)
        {
            return "call from Loginfo :" + infomessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            consolelogger c = new consolelogger();
            string str = c.Logmessage("message");
            string res = c.LogError("error message");
            string res1 = c.LogInfo("Infomessage");
            Console.WriteLine(str);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadKey();
        }
    }
}