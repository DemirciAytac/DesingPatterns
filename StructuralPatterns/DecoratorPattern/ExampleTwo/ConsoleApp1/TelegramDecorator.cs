using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class TelegramDecorator : BaseDecorator
    {

        public TelegramDecorator(INotification wrappee) : base(wrappee)
        {

        }

        public override void sendMessage(string msg)
        {
            base.sendMessage(msg);
            SendTelegram(msg);
        }

        private void SendTelegram(string msg)
        {
            Console.WriteLine($"{msg} message sent in Telegram");
        }
    }
}
