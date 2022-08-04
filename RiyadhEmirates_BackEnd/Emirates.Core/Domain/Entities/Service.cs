
namespace Emirates.Core.Domain.Entities
{
    public class Service : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string RequestLink { get; set; }
        public int? WorkDays { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<RequestAttachmentType> RequestAttachmentTypes { get; set; }
        public virtual ICollection<RequestType> RequestTypes { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<ServiceStage> ServiceStages { get; set; }
    }
}
