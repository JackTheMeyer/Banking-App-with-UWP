using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Interest : Account
    {
        private double _balance;
        private double _interest;

        public Interest(string bsb, string account) : base(bsb, account)
        {
            Name = "Interest";
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

        public void gainInterest()
        {
            _interest += (_balance * 0.01);
        }

        public void lostInterest()
        {
            _interest = 0;
        }
    }
}
