
namespace Emirates.Core.Domain.Entities
{
    public class ServieNotification : AuditFullData<int>
    {
        public int? ServiceId { get; set; }
        public int StageId { get; set; }
        public bool IsSMS { get; set; }
        public bool IsEmail { get; set; }
        public bool IsDefault { get; set; } = false;
        public bool IsActive { get; set; }


        public virtual Service Service { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<ServieNotificationLog> ServieNotificationLogs { get; set; }

    }
}
