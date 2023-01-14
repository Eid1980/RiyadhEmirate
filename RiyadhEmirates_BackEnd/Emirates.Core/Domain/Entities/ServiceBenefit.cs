
namespace Emirates.Core.Domain.Entities
{
    public class ServiceBenefit
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public bool IsBenefit { get; set; }

        public virtual Service Service { get; set; }
    }
}
