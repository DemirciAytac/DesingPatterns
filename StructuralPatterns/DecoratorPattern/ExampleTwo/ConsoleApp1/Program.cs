using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            INotification notifyStack = new Notifier();
            notifyStack = new SMSDecorator(notifyStack);
            notifyStack = new TelegramDecorator(notifyStack);
            notifyStack.sendMessage("Hello Medium");
        }
    }
}
