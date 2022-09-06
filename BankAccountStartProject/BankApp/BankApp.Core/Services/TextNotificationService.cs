using BankApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp.Core.Services
{
    public class TextNotificationService : INotificationService
    {

        // TextWriter path = new StreamWriter(@"C:\Users\Student\Documents\BankNotifications.txt", true);
        public IEnumerable<Notification> GetAllNotifications()
        {
            using (TextWriter path = new StreamWriter(@"C:\Users\Student\source\repos\BankAccountStartProject\BankApp\BankNotifications.txt", true))
            {
                var filePath = @"C:\Users\Student\Documents\BankNotifications.txt";
                
            }
            return GetAllNotifications();
        }
        public void NotifyFraudlentActivity(Account account)
        {
            using (TextWriter path = new StreamWriter(@"C:\Users\Student\source\repos\BankAccountStartProject\BankApp\BankNotifications.txt", true))
            {
                var notification = new Notification()
                {
                    Message = $"{account.Email}: We have detected fraudlent activity on your account with id '{account.Id}'.",
                    AccountId = account.Id,
                    Email = account.Email,
                };
                path.Write(notification.Message, notification.AccountId, notification.Email);
                path.Close();
            }
        }

        public void NotifyFundsLow(Account account)
        {
            using (TextWriter path = new StreamWriter(@"C:\Users\Student\source\repos\BankAccountStartProject\BankApp\BankNotifications.txt", true))
            {
                var notification = new Notification()
                {
                    Message = $"{account.Email}: Your account with id '{account.Id}' has low funds.",
                    AccountId = account.Id,
                    Email = account.Email,
                };
                path.Write(notification.Message, notification.AccountId, notification.Email);
                path.Close();
            }
        }

        public IEnumerable<Notification> GetNotificationsForEmail(string emailAddress)
        {
            var paths = @"C:\Users\Student\source\repos\BankAccountStartProject\BankApp\BankNotifications.txt";

            throw new NotImplementedException();
        }
    }
}