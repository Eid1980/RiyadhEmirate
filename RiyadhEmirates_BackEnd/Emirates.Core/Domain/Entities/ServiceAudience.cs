
namespace Emirates.Core.Domain.Entities
{
    public class ServiceAudience : AuditCreation<int>
    {
        public int ServiceId { get; set; }
        public int AudienceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual Audience Audience { get; set; }
        public virtual User CreatedUser { get; set; }
    }
}
