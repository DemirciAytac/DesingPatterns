﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyOne
{
    public class NetworkServer
    {
        public INetwork GetNetwork()
        {
            return new ProxyServer();
        }
    }
}
