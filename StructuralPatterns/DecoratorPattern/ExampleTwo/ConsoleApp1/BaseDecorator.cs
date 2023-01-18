using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseDecorator : INotification
    {
        private INotification wrappee;
        public BaseDecorator(INotification wrappee)
        {
            this.wrappee = wrappee;
        }
        virtual public void sendMessage(string msg)
        {
            wrappee.sendMessage(msg);
        }
    }
}
