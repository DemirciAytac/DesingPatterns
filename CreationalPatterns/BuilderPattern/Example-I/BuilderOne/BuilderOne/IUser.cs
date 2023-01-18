using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderOne
{
    public interface IUser
    {
        string Name { get; }
        int Age { get; }

        Address Address { get; set; }
    }
}
