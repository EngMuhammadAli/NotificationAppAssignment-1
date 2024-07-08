using NotificationAppAssignment__1.Models;

namespace NotificationAppAssignment__1.Services
{
    public interface INotificationProvider
    {
        Task<Notification> SendNotificationAsync(string recipient, string message);
    }
}
