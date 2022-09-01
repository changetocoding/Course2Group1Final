using BankApp.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    internal class DavidCreateAccountTest
    {
        [Test]
        public void CanSaveAnAccountInTheRepo()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            // Act
            var id = repo.CreateAccount("david@test.com");

            // Assert
            Assert.That(id, Is.EqualTo(1));
            Assert.That(repo.GetAccountById(id).Email, Is.EqualTo("david@test.com"));
        }

        [Test]
        public void ThrowsOnInvalidEmail()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            // Act
            Assert.Throws<Exception>(() => repo.CreateAccount("david"));

        }

        [Test]
        public void WhenAccountDoesNotExist_CannotFetchItFromTheRepo()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            // Act & Assert
            Assert.Throws<AccountNotFoundException>(() => repo.GetAccountById(10));
        }

        [Test]
        public void EmailCode()
        {
            // setup
            var repo = new InMemoryAccountRepository();

            Assert.True(repo.ValidatingEmailAddress("david@test.com"));
            Assert.True(repo.ValidatingEmailAddress("david@gmail.co.uk"));
            Assert.False(repo.ValidatingEmailAddress("david"));
            Assert.False(repo.ValidatingEmailAddress("david@"));
        }
    }
}
