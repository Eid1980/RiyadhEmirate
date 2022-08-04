
namespace Emirates.Core.Domain.Entities
{
    public class News : AuditFullData<int>
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public DateTime Date { get; set; }
        public int NewsTypeId { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }

        public virtual NewsType NewsTypesCode{ get; set; }
    }
}
