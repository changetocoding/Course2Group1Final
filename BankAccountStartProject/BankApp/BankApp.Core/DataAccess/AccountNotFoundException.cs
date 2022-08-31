using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Core.DataAccess
{
    // https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-user-defined-exceptions
    public class AccountNotFoundException: Exception
    {
        public AccountNotFoundException()
        {
        }

        public AccountNotFoundException(string message)
            : base(message)
        {
        }

        public AccountNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
