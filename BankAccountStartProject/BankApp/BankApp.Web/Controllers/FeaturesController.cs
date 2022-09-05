using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly PayInMoney _payInMoney;
        private readonly WithdrawMoney _withdrawMoney;
        private readonly TransferMoney _transferMoney;
        public FeaturesController(PayInMoney payInMoney, WithdrawMoney withdrawMoney, TransferMoney transferMoney)
        {
            _payInMoney = payInMoney;
            _withdrawMoney = withdrawMoney;
            _transferMoney = transferMoney;
        }

        [HttpPut]
        [Route("PayInMoney")]
        public void MakeDeposit(int Id, decimal amount)
        {
            _payInMoney.Execute(Id, amount);
        }

        [HttpPut]
        [Route("WithdrawMoney")]
        public void WithdrawMoney(int Id, decimal amount)
        {
            _withdrawMoney.Execute(Id, amount);
        }

        [HttpPut]
        [Route("TransferMoney")]
        public void TransferBetweenTwoAccounts(int FirstId, int SecondId, decimal amount)
        {
            _transferMoney.Execute(FirstId, SecondId, amount);
        }


    }
}
