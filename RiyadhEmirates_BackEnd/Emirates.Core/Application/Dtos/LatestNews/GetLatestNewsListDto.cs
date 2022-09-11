using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetLatestNewsListDto : CreateLatestNewsDto
    {
        public int Id { get; set; }
        public string NewsCategueryName { get; set; }
        public UploadedFileBase64Model Image { get; set; }
    }
}
