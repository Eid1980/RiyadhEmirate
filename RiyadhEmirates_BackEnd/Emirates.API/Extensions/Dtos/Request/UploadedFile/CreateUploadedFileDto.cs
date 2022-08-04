namespace Emirates.API.Dtos.InternalPortal.Request.UploadedFile
{
    public class CreateUploadedFileDto
    {
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
