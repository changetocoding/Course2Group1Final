﻿using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features
{
    class TransferMoneyTest
    {
        [Test]

        public void CanTrasferMoneyBetweenccount()
        {
            // Setup
            var mockNotificationService = new Mock<INotificationService>();
            var mockAccountRepo = new Mock<IAccountRepository>();

            const int fromAccountId = 1;
            const int toAccountId = 2;
            var account1 = new Account { Id = fromAccountId, BalanceProperty = 1000 };
            var account2 = new Account { Id = toAccountId, BalanceProperty = 200 };

            mockAccountRepo.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            mockAccountRepo.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(mockAccountRepo.Object, mockNotificationService.Object);

            // Act
            transfer.Execute(fromAccountId, toAccountId, 300);

            //Assert
            Assert.That(account1.BalanceProperty, Is.EqualTo(700));
        }
        [Test]
        public void IfTransferMoneyIsNegative_ThenThrowsException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, BalanceProperty = 640 };
            var account2 = new Account { Id = toAccountId, BalanceProperty = 640 };

            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, -230));

            // assert
            Assert.That(account1.BalanceProperty, Is.EqualTo(640));
        }

        [Test]
        public void CannotTransferAboveBalanceInAccount()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, Balance/*BalanceProperty*/ = 640 };
            var account2 = new Account { Id = toAccountId, Balance /*BalanceProperty*/ = 640 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 1000));

            // assert
            Assert.That(account1.bal/*BalanceProperty*/, Is.EqualTo(640));
        }
        [Test]
        public void IfAmountTransferredIsZero_ThrowAnException()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, BalanceProperty = 640 };
            var account2 = new Account { Id = toAccountId, BalanceProperty = 700 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 0));

            // assert
            Assert.That(account1.BalanceProperty, Is.EqualTo(640));
        }

        [Test]
        public void CannotTransferMoney_IFFraudlentActivityDetected()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int fromAccountId = 5;
            const int toAccountId = 4;
            var account1 = new Account { Id = fromAccountId, BalanceProperty = 100_000_000 };
            var account2 = new Account { Id = toAccountId, BalanceProperty = 700 };
            myMock.Setup(x => x.GetAccountById(fromAccountId)).Returns(account1);
            myMock.Setup(x => x.GetAccountById(toAccountId)).Returns(account2);

            var transfer = new TransferMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => transfer.Execute(fromAccountId, toAccountId, 1000));

            // assert
            Assert.That(account1.BalanceProperty, Is.EqualTo(100_000_000));
        }
    }
} 
