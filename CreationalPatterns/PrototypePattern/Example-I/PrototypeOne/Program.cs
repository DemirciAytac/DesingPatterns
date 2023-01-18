using System;

namespace PrototypeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var AccountFactory =new AccountFactory();

            var normalAccount = AccountFactory.CreateNormalAccount();
            normalAccount.IBAN = "123";

            var negativeAccount = AccountFactory.CreateNegativeAccount(new Customer("Aytaç"),500);
            negativeAccount.IBAN = "321";

            var frozenAccount = AccountFactory.CreateFrozenAccount(new Customer("veli"), 800);
            frozenAccount.IBAN = "213";

            Console.WriteLine("Hello World!");
        }
    }
}
