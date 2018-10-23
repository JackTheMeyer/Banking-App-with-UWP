using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Debit : Transaction
    {

        private double _debitAmount;

        public Debit(Account sender, Account reciever, double amount) : base(sender, reciever)
        {
            _debitAmount = amount;
        }

        public override void transact()
        {
            double x = Sender.Balance - _debitAmount;
            if (x >= 0.00)
            {
                Sender.Balance = x;
            }
        }

    }
}
