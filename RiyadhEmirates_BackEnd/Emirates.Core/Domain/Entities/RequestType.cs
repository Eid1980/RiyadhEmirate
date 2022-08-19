

namespace Emirates.Core.Domain.Entities
{
    public class RequestType : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int ServiceId { get; set; }
        public bool IsActive { get; set; }

        public virtual Service Service { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<RequestElectronicBoard> RequestElectronicBoards { get; set; }
        public virtual ICollection<RequestPrisonerTempRelease> RequestPrisonerTempReleases { get; set; }
        public virtual ICollection<RequestPrisonersService> RequestPrisonersServices { get; set; }
        public virtual ICollection<RequestLandsInfringement> RequestLandsInfringements { get; set; }
        public virtual ICollection<RequestElectronicSummon> RequestElectronicSummons { get; set; }
        
    }
}
