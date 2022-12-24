
namespace Emirates.Core.Domain.Entities
{
    public class Service : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string SectorAr { get; set; }
        public string SectorEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string RequestLink { get; set; }
        public string WorkDays { get; set; }
        public double? Cost { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
        public bool IsExternal { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<RequestAttachmentType> RequestAttachmentTypes { get; set; }
        public virtual ICollection<RequestType> RequestTypes { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<ServiceStage> ServiceStages { get; set; }
        public virtual ICollection<ServiceAudience> ServiceAudiences { get; set; }
        public virtual ICollection<ServiceCondition> ServiceConditions { get; set; }
        public virtual ICollection<ServiceBenefit> ServiceBenefits { get; set; }
        public virtual ICollection<ServieNotification> ServieNotifications { get; set; }
    }
}
