using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
     class WithdrawMoneyTest
     {
        [Test]

        public void CanWithdrawMoneyFromAccount()
        {
            // Setup
            var mockNotificationService = new Mock<INotificationService>();
            var mockAccountRepo = new Mock<IAccountRepository>();

            const int fromAccountId = 1;
            var account = new Account { Id = fromAccountId, BalanceProperty = 1000 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account);
            var withdraw = new WithdrawMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // Act
            withdraw.Execute(fromAccountId, 300);

            //Assert
            Assert.That(account.BalanceProperty, Is.EqualTo(700));
        }
        [Test]
        public void IfWithdrawMoneyIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, BalanceProperty = 640 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, -230));

            // assert
            Assert.That(account.BalanceProperty, Is.EqualTo(640));
        }

        [Test]
        public void CannotWithdrawIfAmountIsAboveBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, BalanceProperty = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.BalanceProperty, Is.EqualTo(850));
        }

        [Test]
        public void IfBalanceIsEmpty_CannotWithdraw()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, BalanceProperty = 0 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.BalanceProperty, Is.EqualTo(0));
        }
        [Test]
        public void CannotWithdrawMoney_IfFraudlentActivityIsDetected()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, BalanceProperty = 100_000_000m };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.BalanceProperty, Is.EqualTo(100000000));
        }



    }
}
