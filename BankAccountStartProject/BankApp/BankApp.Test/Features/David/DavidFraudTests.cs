using BankApp.Core.DataAccess;
using BankApp.Core.Domain;
using BankApp.Core.Features;
using BankApp.Core.Services;
using Moq;
using NUnit.Framework;

namespace BankApp.Test.Features.David
{
    class DavidFraudTests
    {
        private WithdrawMoney _withdraw;
        private PayInMoney _deposit;
        private TransferMoney _transfer;
        private Account _accountOverLimit;
        private Account _accountCloseToLimit;
        private Mock<INotificationService> _mockNotificationService;

        [SetUp]
        public void Setup()
        {
            // Setup
            _mockNotificationService = new Mock<INotificationService>();
            var mockAccountRepo = new Mock<IAccountRepository>();

            _accountOverLimit = new Account { Id = 1, Balance = 50_000, PaidIn = 100_000_000 };
            mockAccountRepo.Setup(x => x.GetAccountById(_accountOverLimit.Id)).Returns(_accountOverLimit);

            _accountCloseToLimit = new Account { Id = 2, Balance = 100_000, PaidIn = 99_000_000 };
            mockAccountRepo.Setup(x => x.GetAccountById(_accountCloseToLimit.Id)).Returns(_accountCloseToLimit);

            _withdraw = new WithdrawMoney(mockAccountRepo.Object, _mockNotificationService.Object);
            _deposit = new PayInMoney(mockAccountRepo.Object, _mockNotificationService.Object);
            _transfer = new TransferMoney(mockAccountRepo.Object, _mockNotificationService.Object);
        }

        [Test]
        public void WhenAboveLimit_UnableToPayIn()
        {
            // Act
            Assert.That(() => _deposit.Execute(_accountOverLimit.Id, 3_000), Throws.Exception);

            //Assert
            Assert.That(_accountOverLimit.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void WhenAboveLimit_UnableToWithdraw()
        {
            // Act
            Assert.That(() => _withdraw.Execute(_accountOverLimit.Id, 200), Throws.Exception);

            //Assert
            Assert.That(_accountOverLimit.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void WhenAboveLimit_UnableToTransfer()
        {
            // Act
            Assert.That(() => _transfer.Execute(_accountOverLimit.Id, _accountCloseToLimit.Id, 1_000), Throws.Exception);

            //Assert
            Assert.That(_accountOverLimit.Balance, Is.EqualTo(50_000));
        }

        [Test]
        public void AllowsTransactionThatWillTakeOverLimit()
        {
            // Act
            _deposit.Execute(_accountCloseToLimit.Id, 3_000);

            //Assert
            Assert.That(_accountCloseToLimit.Balance, Is.EqualTo(102_000));
        }


        [Test]
        public void NotifiesThatFraudlentActivityTakenPlace()
        {
            // Act
            _deposit.Execute(_accountCloseToLimit.Id, 3_000);

            //Assert
            Assert.That(_accountCloseToLimit.Balance, Is.EqualTo(102_000));
            _mockNotificationService.Verify(x => x.NotifyFraudlentActivity(_accountCloseToLimit));
        }
    }
}
