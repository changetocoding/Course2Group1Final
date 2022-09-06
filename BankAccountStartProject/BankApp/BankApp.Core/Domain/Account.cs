using System;

namespace BankApp.Core.Domain
{
    public class Account
    {
        public const decimal FraudulentActivityLimit = 100_000_000m;
        public const decimal PayInLimit = 40000m;

        public const decimal LowBalanceThreshold = 500m;
        public const decimal BalanceLimitForWithdraw = 0m;

        public int Id { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Positive number that keeps track of total that has been withdrawn from account
        /// </summary>
        public decimal Withdrawn { get; set; }

        /// <summary>
        /// Positive number that keeps track of total that has been paid into account
        /// </summary>
        /// 

        public decimal PaidIn { get; set; }


        public virtual void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Insufficient funds to withdraw");
            if (FraudulentActivityDectected())
                throw new Exception("Fraudlent activities have been detected in your account");
            if (amount < BalanceLimitForWithdraw)
                throw new InvalidOperationException("The amount entered is negative");
            if (Balance >= FraudulentActivityLimit)
                throw new InvalidOperationException("You cannot withdraw any money from this account due to suspicious activities");
            if (amount == BalanceLimitForWithdraw)
                throw new InvalidOperationException("You cannot withdraw an amount with the value of zero");
            
            if (amount == BalanceLimitForWithdraw)
                throw new InvalidOperationException();
            Balance = Balance - amount;
            Withdrawn = Withdrawn + amount;
            

        }

        public virtual void PayIn(decimal amount)
        {
            if (amount > PayInLimit)
                throw new InvalidOperationException($"You cannot pay in more than {PayInLimit} in a single transaction");
            if (Balance >= FraudulentActivityLimit)
                throw new InvalidOperationException("You cannot pay in any money to this account due to Fraudlent activities");
            if (FraudulentActivityDectected())
                throw new InvalidOperationException("Fraudlent activities have been detected in your account");
            if (amount == 0)
                throw new InvalidOperationException("You cannot pay amount of 0 to your account");
            

            if (amount < 0)
                throw new InvalidOperationException("The amount entered is negative");

            Balance = Balance + amount;
            PaidIn = PaidIn + amount;
        }

        public virtual bool CanWithdraw(decimal amount)
        {
            var newBalance = Balance - amount;
            return newBalance >= BalanceLimitForWithdraw;
        }

        public bool IsLowBalance()
        {
            return Balance < LowBalanceThreshold;
        }

        public bool FraudulentActivityDectected()
        {
            return PaidIn >= FraudulentActivityLimit;
        }
    }
}
