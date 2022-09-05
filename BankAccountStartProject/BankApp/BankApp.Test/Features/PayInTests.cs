using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
    class PayInTests
    {
        [Test]
        public void CanPayInMoneyIntoAccount()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 700 };
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposit = new PayInMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // act 
            deposit.Execute(intoAccountId, 2000);

            // assert
            Assert.That(account.Balance, Is.EqualTo(2700));
        }

        // This test is failing fix it
        [Test]
        public void IfPayInAmountIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 640 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new PayInMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, -230));

            // assert
            Assert.That(account.Balance, Is.EqualTo(640));
        }

        [Test]
        public void CannotPayInAbovePayInLimit()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new PayInMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, 60000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(850));
        }

        [Test]
        public void CannotPayIn_IfFraudlentActivityIsDetected()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 100_000_000m };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new PayInMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(100000000));
        }
    }

    
}
