namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestAttachmentTypeDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int ServiceId { get; set; }
        public string ExtentionAllowed { get; set; }
        public int? MaxFileSize { get; set; }
        public bool IsRequired { get; set; }
        public bool IsActive { get; set; }
    }
}
