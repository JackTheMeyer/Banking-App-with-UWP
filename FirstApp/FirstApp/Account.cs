using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Account
    {
        private string _bsb;
        private string _accountNumber;
        private double _balance;
        private string _name;

        public Account(string bsb, string account)
        {
            _bsb = bsb;
            _accountNumber = account;
            
        }

        public string BSB
        {
            get
            {
                return _bsb;
            }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public double Balance
        {
            get;
            set;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
