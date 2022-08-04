using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetNewsListDto
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public int NewsTypeId { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public UploadedFileBase64Model Image { get; set; }
    }
}
