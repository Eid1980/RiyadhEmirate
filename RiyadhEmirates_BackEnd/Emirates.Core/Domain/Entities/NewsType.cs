
namespace Emirates.Core.Domain.Entities
{
    public class NewsType : AuditFullData<int>
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int NewsTypeCode { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual  ICollection<News> News { get; set; }
    }
}
