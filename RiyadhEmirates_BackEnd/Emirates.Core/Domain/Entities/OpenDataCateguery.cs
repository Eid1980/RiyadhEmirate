
namespace Emirates.Core.Domain.Entities
{
    public class OpenDataCateguery : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataSubCategueryId { get; set; }
        public bool IsActive { get; set; }

        public virtual OpenDataSubCateguery OpenDataSubCateguery { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<OpenDataReport> OpenDataReports { get; set; }
    }
}
