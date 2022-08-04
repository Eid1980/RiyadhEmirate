

namespace Emirates.Core.Application.Dtos
{
    public class GetServiceStageDetailsDto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int StageId { get; set; }
        public string StageName { get; set; }
        public string RequesterUrl { get; set; }
        public string AdminUrl { get; set; }
    }
}
