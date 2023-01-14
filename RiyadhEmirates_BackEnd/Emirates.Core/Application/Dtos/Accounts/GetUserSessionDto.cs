
namespace Emirates.Core.Application.Dtos
{
    public class GetUserSessionDto
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public bool IsEmployee { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }
}
