using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    class DavidTransferMoneyTest
    {
        private Account _fromAccount;
        private Account _toAccount;
        private TransferMoney _transfer;

        [SetUp]
        public void Setup()
        {
            // Setup
            var mockNotificationService = new Mock<INotificationService>();
            var mockAccountRepo = new Mock<IAccountRepository>();

            const int fromAccountId = 1;
            const int toAccountId = 2;
            _fromAccount = new Account { Id = fromAccountId, Balance = 10_000 };
            _toAccount = new Account { Id = toAccountId, Balance = 1_000 };

            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(_fromAccount);
            mockAccountRepo.Setup(x => x.GetAccountById(toAccountId)).Returns(_toAccount);

            _transfer = new TransferMoney(mockAccountRepo.Object, mockNotificationService.Object);
        }

        [Test]
        public void CanTrasferMoneyBetweenAccount()
        {
            // Act
            _transfer.Execute(_fromAccount.Id, _toAccount.Id, 3_000);

            //Assert
            Assert.That(_fromAccount.Balance, Is.EqualTo(7_000));
            Assert.That(_toAccount.Balance, Is.EqualTo(4_000));
        }

        [Test]
        public void IfMoneyIsNegative_ThenThrowsException()
        {
            // act 
            Assert.Throws<InvalidOperationException>(() => _transfer.Execute(_fromAccount.Id, _toAccount.Id, -230));

            // assert
            Assert.That(_fromAccount.Balance, Is.EqualTo(10_000));
            Assert.That(_toAccount.Balance, Is.EqualTo(1_000));
        }

        [Test]
        public void IfMoneyIsZero_ThenThrowsException()
        {
            // act 
            Assert.Throws<InvalidOperationException>(() => _transfer.Execute(_fromAccount.Id, _toAccount.Id, 0));

            // assert
            Assert.That(_fromAccount.Balance, Is.EqualTo(10_000));
            Assert.That(_toAccount.Balance, Is.EqualTo(1_000));
        }

        [Test]
        public void CannotTransferAbovePayInLimit_10_000()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, Balance = 50_000 };
            var account2 = new Account { Id = toAccountId, Balance = 1_000 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 11_000));

            // assert
            Assert.That(account1.Balance, Is.EqualTo(50_000));
            Assert.That(account2.Balance, Is.EqualTo(1_000));
        }

        [Test]
        public void CannotTransferAbovePayInLimit_40_000()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, Balance = 50_000 };
            var account2 = new Account { Id = toAccountId, Balance = 1_000 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 41_000));

            // assert
            Assert.That(account1.Balance, Is.EqualTo(50_000));
            Assert.That(account2.Balance, Is.EqualTo(1_000));
        }

        [Test]
        public void CanTransferBelowPayInLimit_40_000()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, Balance = 50_000 };
            var account2 = new Account { Id = toAccountId, Balance = 1_000 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 20_000));

            // assert
            Assert.That(account1.Balance, Is.EqualTo(30_000));
            Assert.That(account2.Balance, Is.EqualTo(21_000));
        }




        [Test]
        public void NotifiedOfLowBalance()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var fromAccount = new Account { Id = fromAccountId, Balance = 1000 };
            var toAccount = new Account { Id = toAccountId, Balance = 300 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            transfer.Execute(fromAccountId, toAccountId, 501);

            // assert
            Assert.That(fromAccount.Balance, Is.EqualTo(499));
            Assert.That(toAccount.Balance, Is.EqualTo(801));
            mockNotificationService.Verify(x => x.NotifyFundsLow(fromAccount));
        }


        [Test]
        public void MoneyDoesNotMoveIfNotEnoughMoney()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var fromAccount = new Account { Id = fromAccountId, Balance = 1000 };
            var toAccount = new Account { Id = toAccountId, Balance = 300 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(fromAccount);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(toAccount);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.That(() => transfer.Execute(fromAccountId, toAccountId, 1100), Throws.Exception);

            // assert
            Assert.That(fromAccount.Balance, Is.EqualTo(1000));
            Assert.That(toAccount.Balance, Is.EqualTo(300));
        }
    }
}
