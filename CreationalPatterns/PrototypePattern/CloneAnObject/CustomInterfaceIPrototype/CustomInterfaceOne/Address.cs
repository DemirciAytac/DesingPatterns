using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaceOne
{
    public class Address : IPrototype<Address>
    {
        public string City { get; set; }
        public string Street { get; set; }

        public Address CreateDeepCopy()
        {
            return (Address)MemberwiseClone();
        }
    }
}
