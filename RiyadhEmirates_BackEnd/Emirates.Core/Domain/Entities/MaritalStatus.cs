
namespace Emirates.Core.Domain.Entities
{
    public class MaritalStatus : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<RequestMarriageCertificate> RequestMarriageCertificates { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
