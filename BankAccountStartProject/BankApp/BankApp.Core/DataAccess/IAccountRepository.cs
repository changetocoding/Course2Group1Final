using BankApp.Core.Domain;

namespace BankApp.Core.DataAccess
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();

        Account GetAccountById(int accountId);

        int CreateAccount(string emailAddress);

        void Update(Account account);
    }

}
