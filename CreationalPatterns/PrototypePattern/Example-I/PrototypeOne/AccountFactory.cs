using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOne
{
    public class AccountFactory : Factory
    {
        public Account CreateNormalAccount()
        {
            return   (Account)AccountPrototypes.NormalProtoType.Clone();
        }

        public Account CreateNormalAccount(Customer owner, double balance)
        {
            Account Account = (Account)AccountPrototypes.NormalProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }
        public Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account Account = (Account)AccountPrototypes.FrozenProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }

        public Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account Account = (Account)AccountPrototypes.NegativeProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }

        static class AccountPrototypes
        {
            public static Account NormalProtoType = new Account(null, true, true, true);
            public static Account NegativeProtoType = new Account(null, true, true, false);
            public static Account FrozenProtoType = new Account(null, false, false, false);
        }
    }
}
