

namespace Emirates.Core.Application.Dtos
{
    public class UpdateServiceStageDto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int StageId { get; set; }
        public string RequesterUrl { get; set; }
        public string AdminUrl { get; set; }
    }
}
