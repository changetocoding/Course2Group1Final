using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCardApp
{
    public class SimCardAccount
    {

        private double airtime;
       

        public SimCardAccount()
        {

        }

        public SimCardAccount(double airtime)
        {
            this.airtime = airtime;
        }

        public double Airtime
        {
            get { return airtime; }
        }

        public void Recharge(double amount)
        {
            if (amount > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            airtime += amount;
        }

        public void BuyData(double amount)
        {
            if (amount > airtime)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            airtime -= amount;
        }

        public void BorrowAirtime(double amount)
        {
            if (airtime != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            airtime += amount;
        }

        public void Withdraw(double amount)
        {
            airtime -= amount;
        }

        public void Add(double amount)
        {
            airtime += amount;
        }

        public void TransferAirtime(SimCardAccount otherSimcard, double amount)
        {
            if(otherSimcard is null)
            {
                throw new ArgumentNullException(nameof(otherSimcard));
            }
            Withdraw(amount);
            otherSimcard.Add(amount);
            
            
        }

        public bool CheckBalance()
        {
            if (Airtime < 20)
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
