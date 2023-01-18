using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderOne
{
    public class Address
    {
        public string FullAddrees { get; set; }

        public Address(string fullAddrees)
        {
            FullAddrees = fullAddrees;
        }
    }
}
