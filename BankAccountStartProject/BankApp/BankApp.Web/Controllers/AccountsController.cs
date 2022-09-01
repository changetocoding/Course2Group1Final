using BankApp.Core.DataAccess;
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
        public async Task<IActionResult> CreateAccount(string accountEmail)
        {
            var accounts = _accountRepository.CreateAccount(accountEmail);
            return null;
        }
    }


}