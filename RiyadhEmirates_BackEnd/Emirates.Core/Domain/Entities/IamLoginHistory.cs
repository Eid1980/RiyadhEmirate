
namespace Emirates.Core.Domain.Entities
{
    public class IamLoginHistory
    {
        public Guid Id { get; set; }
        public string NationalId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
