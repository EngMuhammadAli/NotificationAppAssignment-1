namespace NotificationAppAssignment__1.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Provider { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
