using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public class Withdraw : ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;
        public ExecutionStatus Status { get; set; }
        public Withdraw(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
            Status = ExecutionStatus.Unprocessed;
        }
        public void Execute()
        {
            if (_account.Balance >= _amount)
            {
                _account.Balance -= _amount;
                Status = ExecutionStatus.ExecuteSucceeded;
            }
            else
            {
                Status = ExecutionStatus.InsufficientFunds;
            }
        }
    }

}
