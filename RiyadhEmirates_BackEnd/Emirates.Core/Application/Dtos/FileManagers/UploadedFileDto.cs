
using Microsoft.AspNetCore.Http;

namespace Emirates.Core.Application.Dtos
{
    public class UploadedFileDto
    {
        public string CategueryName { get; set; }
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
