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
            var account = new Account { Id = fromAccountId, Balance = 1000 };
            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account);
            var withdraw = new WithdrawMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // Act
            withdraw.Execute(fromAccountId, 300);

            //Assert
            Assert.That(account.Balance, Is.EqualTo(700));
        }
        [Test]
        public void IfWithdrawMoneyIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 640 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, -230));

            // assert
            Assert.That(account.Balance, Is.EqualTo(640));
        }

        [Test]
        public void CannotWithdrawIfAmountIsAboveBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(850));
        }

        [Test]
        public void IfBalanceIsEmpty_CannotWithdraw()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 0 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var withdraw = new WithdrawMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => withdraw.Execute(intoAccountId, 6000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(0));
        }

        
        
    }
}
