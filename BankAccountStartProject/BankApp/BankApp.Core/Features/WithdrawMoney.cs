using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Services;
using BankApp.Data.Scaffolded;
using System;

namespace BankApp.Core.Features
{
    public class WithdrawMoney
    {
        private IAccountRepository accountRepository;
        private INotificationService notificationService;

        public WithdrawMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            this.accountRepository = accountRepository;
            this.notificationService = notificationService;
        }

        
        public void Execute(int fromAccountId, decimal amount)
        {
            var from = accountRepository.GetAccountById(fromAccountId);

            // ToDo


            if (from.CanWithdraw(amount) && from.Balance > 0)
            {
                from.Withdraw(amount);
            }

            else if (amount < 0)
            {
                throw new InvalidOperationException("You cannot withdraw negative amount");
            }

            else if (amount == 0)
            {
                throw new InvalidOperationException("You cannot withdraw an amount with value of 0");
            }

            if (from.FraudulentActivityDectected())
            {
                notificationService.NotifyFraudlentActivity(from);
                throw new InvalidOperationException();
            }
            accountRepository.Update(from);
            notificationService.NotifyFundsLow(from);

            
        }
        
    }
}
