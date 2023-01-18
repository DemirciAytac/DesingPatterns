using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOne.Abstract
{
    //Abstract factory
    public abstract class DbProviderFactory
    {
        public abstract DbConnection CreateConnection();
        public abstract DbCommand CreateCommand();
    }
}
