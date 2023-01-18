using AbstractFactoryOne.Abstract;
using Hangfire.PostgreSql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbProviderFactory = AbstractFactoryOne.Abstract.DbProviderFactory;

namespace AbstractFactoryOne.Concrete
{
    //Concrete factory
    public class PostgreSqlClientFactory : DbProviderFactory
    {
        public override DbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public override DbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
}
