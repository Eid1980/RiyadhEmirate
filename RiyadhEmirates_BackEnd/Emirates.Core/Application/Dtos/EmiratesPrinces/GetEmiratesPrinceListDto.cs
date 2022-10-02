
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetEmiratesPrinceListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BehalfToAr { get; set; }
        public string BehalfToEn { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public bool IsActive { get; set; }
        public UploadedFileBase64Model Image { get; set; }
    }
}
