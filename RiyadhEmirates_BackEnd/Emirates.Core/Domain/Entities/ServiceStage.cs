
namespace Emirates.Core.Domain.Entities
{
    public class ServiceStage : AuditFullData<int>
    {
        public int ServiceId { get; set; }
        public int StageId { get; set; }
        public string RequesterUrl { get; set; }
        public string AdminUrl { get; set; }

        public virtual Service Service { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
