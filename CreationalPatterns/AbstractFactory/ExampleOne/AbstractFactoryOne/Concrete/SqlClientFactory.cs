using AbstractFactoryOne.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbProviderFactory = AbstractFactoryOne.Abstract.DbProviderFactory;

namespace AbstractFactoryOne.Concrete
{
    //Concrete factory
    public class SqlClientFactory : DbProviderFactory
    {
        public override DbConnection CreateConnection()
            => new SqlConnection();

        public override DbCommand CreateCommand()
            => new SqlCommand();
    }
}
