using System;

namespace PrototypeTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            var normalAccount = Account.CreateNormalAccount();
            normalAccount.IBAN = "123";

            var negativeAccount = Account.CreateNegativeAccount(new Customer("Aytaç"), 500);
            negativeAccount.IBAN = "321";

            var frozenAccount = Account.CreateFrozenAccount(new Customer("veli"), 800);
            frozenAccount.IBAN = "213";
        }
    }
}
