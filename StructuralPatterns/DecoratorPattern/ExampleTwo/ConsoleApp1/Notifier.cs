using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Notifier : INotification
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine($"{msg} message sent in Email");
        }
    }
}
