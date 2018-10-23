using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Savings : Account
    {
        private double _balance;

        public Savings(string bsb, string account) : base(bsb, account)
        {
            Name = "Savings";
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public void recieveTransaction()
        {
            
        }

        

    }
}
