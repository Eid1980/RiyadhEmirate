
namespace Emirates.Core.Application.Dtos
{
    public class GetCheckedAudienceDto
    {
        public List<CheckedAudience> CheckedAudiences { get; set; }
        public UploadedFileBase64Dto Image { get; set; }
    }

    public class CheckedAudience
    {
        public int Id { get; set; }
        public int AudienceId { get; set; }
        public string AudienceName { get; set; }
        public bool IsChecked { get; set; }

    }
}
