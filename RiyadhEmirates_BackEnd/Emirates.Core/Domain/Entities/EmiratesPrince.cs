
namespace Emirates.Core.Domain.Entities
{
    public class EmiratesPrince : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BehalfToAr { get; set; }
        public string BehalfToEn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ImageName { get; set; }
        public string Cv { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
