using BankApp.Core.DataAccess;
using BankApp.Core.Services;
using System;

namespace BankApp.Core.Features
{
    public class TransferMoney
    {
        private IAccountRepository _accountRepository;
        private INotificationService _notificationService;

        public TransferMoney(IAccountRepository accountRepository, INotificationService notificationService)
        {
            _accountRepository = accountRepository;
            _notificationService = notificationService;
        }

        public void Execute(int fromAccountId, int toAccountId, decimal amount)
        {
            var from = _accountRepository.GetAccountById(fromAccountId);
            var to = _accountRepository.GetAccountById(toAccountId);



            if (from.CanWithdraw(amount) && from.Balance > 0 && amount > 0)
            {
                from.Withdraw(amount);
                to.PayIn(amount);
            }

            else if (amount < 0)
            {
                throw new InvalidOperationException("You cannot transfer negative amounts");
            }
            else if(amount == 0)
            {
                throw new InvalidOperationException("You cannot transfer an amount with a value of 0");
            }
            else if(amount > from.Balance)
            {
                throw new InvalidOperationException("You cannot transfer amounts greater than your balance");
            }

            _accountRepository.Update(from);
            _accountRepository.Update(to);
            _notificationService.NotifyFundsLow(from);
            _notificationService.NotifyFundsLow(to);

        }
    }
}
