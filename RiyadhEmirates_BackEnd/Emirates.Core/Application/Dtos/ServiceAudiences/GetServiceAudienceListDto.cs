
namespace Emirates.Core.Application.Dtos
{
    public class GetServiceAudienceListDto : CreateServiceAudienceDto
    {
        public int Id { get; set; }
        public string AudienceName { get; set; }
    }
}
