using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTwo
{
    public class Account : ICloneable
    {
        private static Account NormalProtoType = new Account(null, true, true, true);
        private static Account NegativeProtoType = new Account(null, true, true, false);
        private static Account FrozenProtoType = new Account(null, false, false, false);
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public Customer Customer { get; set; }
        public bool IsOpenToWithdraw { get; set; }
        public bool IsOpenToPayment { get; set; }
        public bool IsOpenToTransfer { get; set; }

        private Account(Customer customer, bool isOpenToWithdraw, bool isOpenToPayment, bool isOpenToTransfer)
        {
            Customer = customer;
            IsOpenToPayment = isOpenToWithdraw;
            IsOpenToTransfer = isOpenToTransfer;
            IsOpenToWithdraw = isOpenToTransfer;
        }
        public object Clone()
        {
            var account = (Account)MemberwiseClone();
            return account;
        }
        public static Account CreateNormalAccount()
        {
            return (Account)NormalProtoType.Clone();
        }

        public static Account CreateNormalAccount(Customer owner, double balance)
        {
            Account Account = (Account)NormalProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }
        public static Account CreateFrozenAccount(Customer owner, double balance)
        {
            Account Account = (Account)FrozenProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }

        public  static Account CreateNegativeAccount(Customer owner, double balance)
        {
            Account Account = (Account)NegativeProtoType.Clone();
            Account.Customer = owner;
            Account.Balance = balance;
            return Account;
        }

    }
}
