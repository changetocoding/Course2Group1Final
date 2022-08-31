using BankApp.Core.Domain;
using BankApp.Core.Services;
using NUnit.Framework;

namespace BankApp.Test.Services
{
    // Delete these in task 2.2
    internal class NotificationServiceTests
    {
        [Test]
        public void CanNotifyAboutFraudlentActivity()
        {
            // setup
            var service = new NotificationService();
            var account = new Account() { Id = 1, Email = "test.co" };

            // Act
            service.NotifyFraudlentActivity(account);

            // Assert
            Assert.That(service.GetAllNotifications().ToList(), Has.Count.EqualTo(1));
            Assert.That(service.GetNotificationsForEmail("test.co").ToList(), Has.Count.EqualTo(1));
            Assert.That(service.GetNotificationsForEmail("test.co").First().Message, 
                Is.EqualTo("test.co: We have detected fraudlent activity on your account with id '1'."));
        }

        [Test]
        public void CanNotifyAboutLowFunds()
        {
            // setup
            var service = new NotificationService();
            var account = new Account() { Id = 1, Email = "test.co" };

            // Act
            service.NotifyFundsLow(account);

            // Assert
            Assert.That(service.GetAllNotifications().ToList(), Has.Count.EqualTo(1));
            Assert.That(service.GetNotificationsForEmail("test.co").ToList(), Has.Count.EqualTo(1));
            Assert.That(service.GetNotificationsForEmail("test.co").First().Message,
                Is.EqualTo("test.co: Your account with id '1' has low funds."));
        }

    }
}
