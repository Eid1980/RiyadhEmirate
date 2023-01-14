namespace Emirates.Core.Application.Dtos.MainPoints
{
    public class UpdateMainPoint
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int Order { get; set; }
        public int? PageContentId { get; set; }
    }
}
