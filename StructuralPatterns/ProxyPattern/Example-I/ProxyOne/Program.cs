using System;

namespace ProxyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkServer networkServer = new NetworkServer();
            INetwork network = networkServer.GetNetwork();

            network.FTP();
            network.Telnet();

            INetwork network2 = networkServer.GetNetwork();
        }
    }
}
