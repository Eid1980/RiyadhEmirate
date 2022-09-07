
namespace Emirates.Core.Domain.Entities
{
    public class ServiceCondition : AuditFullData<int>
    {
        public int ServiceId { get; set; }
        public string Condition { get; set; }
        public int Order { get; set; }

        public virtual Service Service { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
