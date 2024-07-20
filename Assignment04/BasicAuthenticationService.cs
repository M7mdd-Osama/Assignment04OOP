using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class BasicAuthenticationService : IAuthenticationService, IComparable
    {
        string[] usernames = { "Mohamed", "Ali" };
        string[] passwords = { "123456", "02468" };
        string[] roles = { "admin", "user" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }

        public int CompareTo(object? obj)
        {

            BasicAuthenticationService? OtherService = (BasicAuthenticationService?)obj;
            if (OtherService is not null)
            {
                return string.Compare(this.usernames[0], OtherService.usernames[0], StringComparison.Ordinal);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
}

