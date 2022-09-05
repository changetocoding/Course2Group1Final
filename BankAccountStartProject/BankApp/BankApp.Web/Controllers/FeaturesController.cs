using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly Account _accountFeatures;
        public FeaturesController(Account accountFeatures)
        {
            _accountFeatures = accountFeatures;
        }

        [HttpPut]
        [Route("Pay In Money")]
        public void MakePayment(int Id, decimal amount)
        {
            _accountFeatures.PayIn(amount);
        }
        
    }
}
