using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyOne
{
    public class Logger
    {
        public static void log(string text)
        {
            Console.WriteLine($"{text}Logged...");
        }
    }
}
