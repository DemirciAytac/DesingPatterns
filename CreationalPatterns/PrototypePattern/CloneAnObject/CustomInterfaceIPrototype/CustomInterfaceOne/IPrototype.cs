using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaceOne
{
    public interface IPrototype<T>
    {
        T CreateDeepCopy();
    }
}
