using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    class DavidWithdrawTests
    {
        private WithdrawMoney _withdraw;
        private Account _account;

        [SetUp]
        public void Setup()
        {
            // Setup
            var mockNotificationService = new Mock<INotificationService>();
            var mockAccountRepo = new Mock<IAccountRepository>();

            const int fromAccountId = 1;
            _account = new Account { Id = fromAccountId, Balance = 50_000 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(_account);
            _withdraw = new WithdrawMoney(mockAccountRepo.Object, mockNotificationService.Object);
        }

        [Test]
        public void CanWithdrawMoneyFromAccount()
        {
            // Act
            _withdraw.Execute(_account.Id, 3_000);

            //Assert
            Assert.That(_account.Balance, Is.EqualTo(47_000));
        }

        [Test]
        public void IfWithdrawMoneyIsNegative_ThenThrowsException()
        {
            // act 
            Assert.That(() => _withdraw.Execute(_account.Id, -230), Throws.Exception);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void IfWithdrawMoneyIsZero_ThenThrowsException()
        {
            // act 
            Assert.That(() => _withdraw.Execute(_account.Id, 0), Throws.Exception);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void CannotWithdrawMoreThanBalance()
        {
            // act 
            Assert.That(() => _withdraw.Execute(_account.Id, 60_000), Throws.Exception);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void NotifiedOfLowBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            withdraw.Execute(intoAccountId, 351);

            // assert
            Assert.That(account.Balance, Is.EqualTo(499));
            mockNotificationService.Verify(x => x.NotifyFundsLow(It.IsAny<Account>()));
        }
    }
}
