namespace Emirates.Core.Application.Models.InternalPortal.Response.FileManager
{
    public class GetUploadedFileModel
    {
        public int Id { get; set; }
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Extention { get; set; }
        public string Base64File { get; set; }
        public bool IsActive { get; set; }
    }
}
