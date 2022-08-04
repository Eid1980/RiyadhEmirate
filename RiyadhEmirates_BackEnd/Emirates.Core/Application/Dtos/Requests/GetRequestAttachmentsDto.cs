
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestAttachmentsDto
    {
        public Guid Id { get; set; }
        public string AttachmentName { get; set; }
        public string FileName { get; set; }
    }
}
