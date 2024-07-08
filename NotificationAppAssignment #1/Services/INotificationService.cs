using NotificationAppAssignment__1.Models;

namespace NotificationAppAssignment__1.Services
{
    public interface INotificationService
    {
        Task<List<Notification>> SendNotificationsAsync(string recipient, string message);
    }
}
