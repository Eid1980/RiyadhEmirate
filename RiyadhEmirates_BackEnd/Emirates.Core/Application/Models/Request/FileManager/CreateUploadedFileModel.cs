using Microsoft.AspNetCore.Http;

namespace Emirates.Core.Application.Models.InternalPortal.Request.FileManager
{
    public class CreateUploadedFileModel
    {
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string SubEntityName { get; set; }
        public string Name { get; set; } 
        public string OriginalName { get; set; }
        public string Extention { get; set; }
        public IFormFileCollection Files { get; set; }
    }
}
