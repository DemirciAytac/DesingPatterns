using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonCommadPattern
{
    // This is a sample of a non-command version,
    // where functions are executed on an object immediately.
    public class Account
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public Account(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Overdraft error");
            }
            Balance -= amount;
        }
    }
}
