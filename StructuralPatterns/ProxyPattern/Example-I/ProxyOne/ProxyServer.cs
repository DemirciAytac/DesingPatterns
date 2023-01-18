using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyOne
{
    public class ProxyServer : INetwork
    {
        private INetwork gateway;
        public ProxyServer()
        {
            gateway = Gateway.GetInstance();
        }

        //Gatewayin FTP işleminden önce araya loglama sokmuş olduk;
        public void FTP()
        {
            Logger.log("FTP");
            gateway.FTP();
        }

        public void Telnet()
        {
            Logger.log("Telnet");
            gateway.Telnet();
        }
    }
}
