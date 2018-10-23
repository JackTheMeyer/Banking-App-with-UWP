using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class User
    {
        private string _username;
        private string _password;
        List<Account> _accounts = new List<Account>();
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
        }

        public List<Account> AccountList
        {
            get
            {
                return _accounts;
            }
        }


    }
}
