
namespace Emirates.Core.Domain.Entities
{
    public class ServiceRate
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int StarsCount { get; set; }
        public string Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User CreatedUser { get; set; }

    }
}
