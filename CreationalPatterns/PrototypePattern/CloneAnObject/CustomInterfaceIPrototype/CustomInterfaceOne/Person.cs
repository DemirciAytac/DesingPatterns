using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaceOne
{
    public class Person : IPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person CreateDeepCopy()
        {
            var person = (Person)MemberwiseClone();
            person.Address = Address.CreateDeepCopy();
            return person;
        }
    }
}
