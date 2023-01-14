
namespace Emirates.Core.Domain.Entities
{
    public class ContactUsMessageType
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ContactUsMessage> ContactUsMessages { get; set; }
    }
}
