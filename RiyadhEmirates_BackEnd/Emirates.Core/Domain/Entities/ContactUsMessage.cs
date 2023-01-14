
namespace Emirates.Core.Domain.Entities
{
    public class ContactUsMessage
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int ContactUsMessageTypeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsReplied { get; set; }

        public DateTime CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }


        public virtual ContactUsMessageType ContactUsMessageType { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
