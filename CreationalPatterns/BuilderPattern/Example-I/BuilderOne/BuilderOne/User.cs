using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderOne
{
    public class User : IUser
    {
        private  string name;
        private  int age;
        private Address address;

        public User()
        {

        }

        public string Name { get { return name; } }

        public int Age { get { return age; } }

        public Address Address { get ; set; }

        public class UserBuilder
        {
            private readonly User user;
            public UserBuilder()
            {
                user = new User();
            }

            public UserBuilder WithName(string name)
            {
                user.name = name;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                user.address = new Address(address);
                return this;
            }

            public User Build()
            {
                return user;
            }
        }

    }
}
