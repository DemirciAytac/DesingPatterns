using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeOne
{
    public interface Factory
    {
        Account CreateNormalAccount();
        Account CreateNormalAccount(Customer owner, double balance);
        Account CreateNegativeAccount(Customer owner, double balance);
        Account CreateFrozenAccount(Customer owner, double balance);
    }
}
