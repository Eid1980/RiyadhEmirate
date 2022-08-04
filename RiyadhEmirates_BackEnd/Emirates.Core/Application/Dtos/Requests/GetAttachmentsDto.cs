using System;

namespace Emirates.Core.Application.Dtos
{
    public class GetAttachmentsDto
    {
        public Guid Id { get; set; }
        public int AttachmentTypeId { get; set; }
        public string AttachmentName { get; set; }
        public string ExtentionAllowed { get; set; }
        public int? MaxFileSize { get; set; }
        public bool AttachmentIsRequired { get; set; }
        public bool IsAdded { get; set; }
        public string FileDescription { get; set; }

    }
}
