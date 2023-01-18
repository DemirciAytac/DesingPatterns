using System;

namespace BuilderOne
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User.UserBuilder().WithAge(25).WithName("Aytac").Build();
            User userWithAddress = new User.UserBuilder().WithAddress("istanbul aranavutkoy").Build();

        }
    }
}
