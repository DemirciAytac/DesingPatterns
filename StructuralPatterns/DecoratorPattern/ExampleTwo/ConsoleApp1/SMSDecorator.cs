using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(INotification wrappee) : base(wrappee)
        {

        }

        public override void sendMessage(string msg)
        {
            base.sendMessage(msg);
            SendSMS(msg);
        }

        private void SendSMS(string msg)
        {
            Console.WriteLine($"{msg} message sent in SMS");
        }
    }
}
