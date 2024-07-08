using NotificationAppAssignment__1.Models;

namespace NotificationAppAssignment__1.Services
{
    public class EmailNotificationProvider : INotificationProvider
    {
        public Task<Notification> SendNotificationAsync(string recipient, string message)
        {
            // Pseudo code for sending email
            var notification = new Notification
            {
                Id = Guid.NewGuid(),
                Provider = "Email",
                Recipient = recipient,
                Message = message,
                Timestamp = DateTime.UtcNow
            };

            return Task.FromResult(notification);
        }

        
    }
}
