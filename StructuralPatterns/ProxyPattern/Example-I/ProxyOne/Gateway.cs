using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyOne
{
    public class Gateway : INetwork
    {
        private static Gateway gateway = new Gateway();
        public void FTP()
        {
            Console.WriteLine(" makes FTP request");
        }

        public void Telnet()
        {
            Console.WriteLine(" makes TELNET request");
        }

        public static Gateway GetInstance()
        {
            return gateway;
        }
    }
}
