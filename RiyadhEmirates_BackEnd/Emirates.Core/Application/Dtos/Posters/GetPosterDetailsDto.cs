

using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos.Posters
{
    public class GetPosterDetailsDto
    {
        public int Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public UploadedFileBase64Model Image { get; set; }
    }
}
