
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetRequestAttachmentsDto
    {
        public Guid Id { get; set; }
        public string AttachmentName { get; set; }
        public string FileName { get; set; }

        //public UploadedFileBase64Model Image { get; set; }

    }
}
