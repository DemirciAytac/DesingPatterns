using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleDesingPatternSolution
{
    public  class User
    {
        public string Name { get; private set; }
        public UserStatus Status { get; private set; }
        public User(String name, UserStatus status)
        {
            Name = name;
            Status = status;

        }
    }

    public enum UserStatus
    {
        Normal,
        Premium

    }
}
