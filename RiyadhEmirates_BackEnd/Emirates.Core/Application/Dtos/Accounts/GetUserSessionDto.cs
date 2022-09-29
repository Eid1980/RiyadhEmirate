
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos
{
    public class GetUserSessionDto
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public bool IsEmployee { get; set; }

        public UploadedFileBase64Model Image { get; set; }
        public string RoleIds { get; set; }
    }
}
