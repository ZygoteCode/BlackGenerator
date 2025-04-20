using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGenerator_XS.Logger
{
    internal class Logger
    {
        public static void LoggerDebug(string contenuto)
        {
            Console.Write("[");
            Console.Write("Debug");
            Console.Write("] " + contenuto + "\r\n");
        }
    }
}
