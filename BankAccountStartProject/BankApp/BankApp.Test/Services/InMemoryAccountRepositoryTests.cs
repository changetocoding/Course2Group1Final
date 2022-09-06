using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using NUnit.Framework;

namespace BankApp.Test.Services
{
    // Delete these in task 2.2
    internal class InMemoryAccountRepositoryTests
    {
        [Test]
        public void CanAddAnNewAccount()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            // Act
            var accountId = repo.CreateAccount("test@test.co");

            // Assert
            var actual = repo.GetAccountById(accountId);
            Assert.That(actual.Email, Is.EqualTo("test@test.co"));
        }

        [Test]
        public void CanSaveAnAccountInTheRepo()
        {
            // setup
            var repo = new InMemoryAccountRepository();
            var account = new Account { Id = 10, Balance = 100 };

            // Act
            repo.Update(account);

            // Assert
            Assert.That(repo.GetAccountById(10), Is.EqualTo(account));
        }

        [Test]
        public void WhenAccountDoesNotExist_CannotFetchItFromTheRepo()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            // Act & Assert
            Assert.Throws<AccountNotFoundException>(() => repo.GetAccountById(0));
        }
    }
}
