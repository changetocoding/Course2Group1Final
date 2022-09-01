using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using BankApp.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    class DavidWebApiTests
    {
        private Account _account;
        private Mock<IAccountRepository> _mockAccountRepo;

        [SetUp]
        public void Setup()
        {
            // Setup
            var mockNotificationService = new Mock<INotificationService>();
            _mockAccountRepo = new Mock<IAccountRepository>();

            const int fromAccountId = 1;
            _account = new Account { Id = fromAccountId, Balance = 50_000 };
            _mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(_account);
        }

        [Test]
        public async Task CanCreateAnAccount_valid_email()
        {
            // Arrange
            var accountsController = new AccountsController(_mockAccountRepo.Object);

            // Act
            var response = await accountsController.CreateAccount("test@test.com");

            //Assert
            Assert.IsInstanceOf<OkObjectResult>(response);

        }

        [Test]
        public async Task CannotCreateAnAccount_invalid_email()
        {
            // Arrange
            var accountsController = new AccountsController(_mockAccountRepo.Object);

            // Act
            var response = await accountsController.CreateAccount("test@");

            //Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(response);

        }

    }

 }
