using BankApp.Core.Domain;

namespace BankApp.Core.Services
{
    // DO NOT CHANGE THIS CLASS
    public interface INotificationService
    {
        void NotifyFraudlentActivity(Account account);

        void NotifyFundsLow(Account account);

        IEnumerable<Notification> GetNotificationsForEmail(string emailAddress);

        IEnumerable<Notification> GetAllNotifications();
    }

    public class Notification
    {
        public string Message { get; internal set; }
        public int AccountId { get; set; }
        public string Email { get; set; }
    }
}
