using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpify.CS
{
    public class User
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public UserType Type { get; set; }

        public User(String Name, String Password, UserType Type)
        {
            this.Name = Name;
            this.Password = Password;
            this.Type = Type;
        }
    }
}
