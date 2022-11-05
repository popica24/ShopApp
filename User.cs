using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class User
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        private bool isAdmin { get; set; }
        public override string ToString()
        {
            return $"User : {Username}";
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User)) return false;
            User other = obj as User;

            return this.Username == other.Username && this.Password == other.Password;
        }
    }
}
