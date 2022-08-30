using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        public double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }
    }
}
