
namespace Emirates.Core.Application.Dtos
{
    public class GetServiceListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string SectorAr { get; set; }
        public string SectorEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string RequestLink { get; set; }
        public string WorkDays { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
        public bool IsExternal { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
