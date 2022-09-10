namespace Emirates.Core.Domain.Entities
{
    public class PageContent : AuditFullData<int>
    {
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string PageContentType { get; set; }

        public virtual ICollection<MainPagePoints> MainPagePoints { get; set; }
    }
}
