using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public IEnumerable<AccountDetails> Get()
        {
            var accounts = _accountRepository.GetAll();
            return accounts.Select(x => new AccountDetails()
            {
                Balance = x.Balance,
                Id = x.Id,
                EmailAddress = x.Email
            });
        }

        [HttpPost]
        [Route("CreateAccount")]
        public int Create(string emailAddress)
        {
            var account = _accountRepository.CreateAccount(emailAddress);
            return account;
        }

        [HttpPut]
        [Route("UpdateAccount")]
        public void Update(Account accountDetails)
        {
           
            var account = new Account() { Balance = accountDetails.Balance, Email = accountDetails.Email, 
                                          Id = accountDetails.Id, PaidIn = accountDetails.PaidIn, 
                                          Withdrawn = accountDetails.Withdrawn };
            _accountRepository.Update(account);
        }
    }


}