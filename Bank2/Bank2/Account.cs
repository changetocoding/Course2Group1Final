using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      

namespace Bank2
{
    public class Account
    {
        private double balance;
        

        public Account()
        {

        }
        public Account(double balance)
        {
            this.balance = balance;
        }
        public double Balance
        {
            get { return balance; }
        }

        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            if(amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            balance -= amount;
        }

        public void TransferFundsTo(Account otheraccount, double amount)
        {
            if(otheraccount is null)
            {
                throw new ArgumentNullException(nameof(otheraccount));
            }
            Withdraw(amount);
            otheraccount.Add(amount);
        }


        public bool CheckLowBalance()
        {
            
            if (Balance < 5500)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
