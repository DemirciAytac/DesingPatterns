using AbstractFactoryOne.Abstract;
using AbstractFactoryOne.Concrete;
using System;

namespace AbstractFactoryOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //En başta sql ile çalışıyor olabiiliriz.
            DbProviderFactory provider = new SqlClientFactory();
            //Daha sonra SqlClientFactory yerine PostgreSqlClientFactory ile çalışmaya karar verirsek 
            //DbProviderFactory provider = new PostgreSqlClientFactory();
            provider.CreateCommand();
            provider.CreateCommand();

        }
    }
}
