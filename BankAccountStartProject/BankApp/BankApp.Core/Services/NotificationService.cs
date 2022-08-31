using BankApp.Core.Domain;

namespace BankApp.Core.Services
{
    // DO NOT CHANGE THIS CLASS
    public class NotificationService : INotificationService
    {
        private readonly List<Notification> _notifications;
        public NotificationService()
        {
            _notifications = new List<Notification>();
        }

        public void NotifyFraudlentActivity(Account account)
        {
            var notification = new Notification()
            {
                Message = $"{account.Email}: We have detected fraudlent activity on your account with id '{account.Id}'.",
                AccountId = account.Id,
                Email = account.Email,
            };

            _notifications.Add(notification);
        }

        public void NotifyFundsLow(Account account)
        {
            var notification = new Notification()
            {
                Message = $"{account.Email}: Your account with id '{account.Id}' has low funds.",
                AccountId = account.Id,
                Email = account.Email,
            };

            _notifications.Add(notification);
        }

        public IEnumerable<Notification> GetNotificationsForEmail(string emailAddress)
        {
            return _notifications.Where(x => x.Email == emailAddress);
        }


        public IEnumerable<Notification> GetAllNotifications()
        {
            return _notifications.ToList();
        }
    }
}
