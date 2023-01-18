using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOne
{
    public class Account : ICloneable
    {
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public Customer Customer { get; set; }
        public bool IsOpenToWithdraw { get; set; }
        public bool IsOpenToPayment { get; set; }
        public bool IsOpenToTransfer { get; set; }

        public Account( Customer customer, bool isOpenToWithdraw, bool isOpenToPayment, bool isOpenToTransfer)
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
    }
}
