using BankApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    // DO NOT CHANGE THIS CLASS
    [ApiController]
    [Route("[controller]")]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Notification> Get()
        {
            return _notificationService.GetAllNotifications();
        }

        [HttpGet]
        [Route("GetForEmail")]
        public IEnumerable<Notification> GetForEmail(string email)
        {
            return _notificationService.GetNotificationsForEmail(email);
   
        }
    }
}
