
namespace Emirates.Core.Domain.Entities
{
    public class Auction : AuditFullData<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
