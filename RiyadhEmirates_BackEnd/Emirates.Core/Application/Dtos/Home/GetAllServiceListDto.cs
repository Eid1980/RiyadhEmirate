using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetAllServiceListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public string RequestLink { get; set; }
        public bool IsExternal { get; set; }
        public int RequestCount { get; set; }
        public UploadedFileBase64Model Image { get; set; }
    }
}
