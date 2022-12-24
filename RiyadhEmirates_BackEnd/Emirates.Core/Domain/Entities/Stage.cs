
namespace Emirates.Core.Domain.Entities
{
    public  class Stage : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool CanEdit { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<RequestStageLog> RequestStageLogs { get; set; }
        public virtual ICollection<ServiceStage> ServiceStages { get; set; }
        public virtual ICollection<ServieNotification> ServieNotifications { get; set; }

    }
}
