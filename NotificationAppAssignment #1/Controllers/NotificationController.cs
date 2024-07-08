using Microsoft.AspNetCore.Mvc;
using NotificationAppAssignment__1.Services;

namespace NotificationAppAssignment__1.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public IActionResult SendNotification()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendNotification(string recipient, string message)
        {
            if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(message))
            {
                ModelState.AddModelError("", "Recipient and Message are required.");
                return View();
            }

            var notifications = await _notificationService.SendNotificationsAsync(recipient, message);
            return View("NotificationResult", notifications);
        }
    }
}
