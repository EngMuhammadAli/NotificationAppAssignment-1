using NotificationAppAssignment__1.Models;

namespace NotificationAppAssignment__1.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IEnumerable<INotificationProvider> _notificationProviders;

        public NotificationService(IEnumerable<INotificationProvider> notificationProviders)
        {
            _notificationProviders = notificationProviders;
        }

        public async Task<List<Notification>> SendNotificationsAsync(string recipient, string message)
        {
            var notifications = new List<Notification>();

            foreach (var provider in _notificationProviders)
            {
                var notification = await provider.SendNotificationAsync(recipient, message);
                notifications.Add(notification);
            }

            return notifications;
        }
    }
}
