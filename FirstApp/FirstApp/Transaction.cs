using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public abstract class Transaction
    {
        private Account _sender;
        private Account _reciever;

        public Transaction(Account sender, Account reciever)
        {
            _sender = sender;
            _reciever = reciever;
        }

        public abstract void transact();

        public Account Sender
        {
            get
            {
                return _sender;
            }
        }

        public Account Reciever
        {
            get
            {
                return _reciever;
            }
        }
    }
}
