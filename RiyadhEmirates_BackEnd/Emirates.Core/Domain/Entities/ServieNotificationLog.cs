
namespace Emirates.Core.Domain.Entities
{
    public class ServieNotificationLog : AuditFullData<int>
    {
        public int ServieNotificationId { get; set; }
        public string Message { get; set; }
        public DateTime? EndDate { get; set; }


        public virtual ServieNotification ServieNotification { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
