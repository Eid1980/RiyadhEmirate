
namespace Emirates.Core.Application.Dtos
{
    public class CreateServiceStageDto
    {
        public int ServiceId { get; set; }
        public int StageId { get; set; }
        public string RequesterUrl { get; set; }
        public string AdminUrl { get; set; }
    }
}
