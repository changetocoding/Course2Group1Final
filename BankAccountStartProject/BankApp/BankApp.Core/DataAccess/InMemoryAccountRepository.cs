using BankApp.Core.Domain;
using System.Text.RegularExpressions;

namespace BankApp.Core.DataAccess
{
    // Do not write tests for this
    public class InMemoryAccountRepository : IAccountRepository
    {
        private readonly Dictionary<int, Account> _accounts;
        private int _lastId = 1;

        public InMemoryAccountRepository()
        {
            _accounts = new Dictionary<int, Account>();
        }

        public bool ValidatingEmailAddress(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
             Regex re = new Regex(strRegex);
             if (re.IsMatch(email))
                return (true);
             else
                return (false);
        }

        public int CreateAccount(string emailAddress)
        {
            if(ValidatingEmailAddress(emailAddress) is true)
            {
                var account = new Account();
                account.Id = _lastId++;
                account.Email = emailAddress;
                _accounts.Add(account.Id, account);

                return account.Id;
            }
            else
            {
                throw new Exception("The Email Address you entered is not valid");
            }
            
        }

        public Account GetAccountById(int accountId)
        {
            if (!_accounts.ContainsKey(accountId))
            {
                throw new AccountNotFoundException($"Account with id {accountId} was not found");
            }

            return _accounts[accountId];
        }

        public IEnumerable<Account> GetAll()
        {
            return _accounts.Values.ToList();
        }

        public void Update(Account account)
        {
           _accounts[account.Id] = account;
        }
    }
}
