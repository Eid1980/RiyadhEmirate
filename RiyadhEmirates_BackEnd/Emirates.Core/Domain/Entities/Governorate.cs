
namespace Emirates.Core.Domain.Entities
{
    public class Governorate : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string PhoneNumber { get; set; }
        public string LocationLink { get; set; }
        public string PortalLink { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RequestLandsInfringement> RequestLandsInfringements { get; set; }
        public virtual ICollection<RequestForeignersRealtyOwner> RequestForeignersRealtyOwners { get; set; }
    }
}
