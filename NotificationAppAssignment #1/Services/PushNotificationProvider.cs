using NotificationAppAssignment__1.Models;

namespace NotificationAppAssignment__1.Services
{
    public class PushNotificationProvider : INotificationProvider
    {
        public Task<Notification> SendNotificationAsync(string recipient, string message)
        {
            // Pseudo code for sending push notification
            var notification = new Notification
            {
                Id = Guid.NewGuid(),
                Provider = "Push",
                Recipient = recipient,
                Message = message,
                Timestamp = DateTime.UtcNow
            };

            return Task.FromResult(notification);
        }
    }
}
