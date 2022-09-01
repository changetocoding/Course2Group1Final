using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    internal class DavidPayInTest
    {
        private PayInMoney _deposit;
        private Account _account;

        [SetUp]
        public void Setup()
        {
            var mockNotificationService = new Mock<INotificationService>();

            var mockAccountRepo = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            _account = new Account { Id = intoAccountId, Balance = 1000 };
            mockAccountRepo.Setup(x => x.GetAccountById(intoAccountId)).Returns(_account);

            _deposit = new PayInMoney(mockAccountRepo.Object, mockNotificationService.Object);
        }


        [Test]
        public void CanPayInMoneyIntoAccount()
        {
            // setup

            // act 
            _deposit.Execute(_account.Id, 2000);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(3000));
        }

        // This test is failing fix it
        [Test]
        public void IfPayInAmountIsNegative_ThenThrowsException()
        {

            // act 
            Assert.That(() => _deposit.Execute(_account.Id, -230), Throws.Exception);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void IfPayInAmountIsZero_ThenThrowsException()
        {
            // act 
            Assert.That(() => _deposit.Execute(_account.Id, 0), Throws.Exception);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void CannotPayInAbovePayInLimit_10_000()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new PayInMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, 11_000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(850));
        }

        [Test]
        public void CannotPayInAbovePayInLimit_40_000()
        {
            // setup
            var mockNotificationService = new Mock<INotificationService>();

            var myMock = new Mock<IAccountRepository>();
            const int intoAccountId = 5;
            var account = new Account { Id = intoAccountId, Balance = 850 };

            myMock.Setup(x => x.GetAccountById(intoAccountId)).Returns(account);

            var deposite = new PayInMoney(myMock.Object, mockNotificationService.Object);

            // act 
            Assert.Throws<InvalidOperationException>(() => deposite.Execute(intoAccountId, 41_000));

            // assert
            Assert.That(account.Balance, Is.EqualTo(850));
        }

        [Test]
        public void CanPayInBelowLimit_40_000()
        {
            // act 
            _deposit.Execute(_account.Id, 20_000);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(21_000));
        }

        [Test]
        public void CanPayInBelowLimit_10_000()
        {
            // act 
            _deposit.Execute(_account.Id, 8_000);

            // assert
            Assert.That(_account.Balance, Is.EqualTo(9_000));
        }
    }
}
