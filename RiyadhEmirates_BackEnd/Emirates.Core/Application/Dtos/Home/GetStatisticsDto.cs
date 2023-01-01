
namespace Emirates.Core.Application.Dtos
{
    public class GetStatisticsDto
    {
        public int UserCount { get; set; }
        public int RequestCount { get; set; }
        public int RequestFinishedCount { get; set; }
        public int RequestElectronicBoardsCount { get; set; }
        public List<GetRequestStatisticsDto> ServiceRequests { get; set; }
        public List<GetRequestStatisticsDto> StageRequests { get; set; }
        public List<GetRequestStatisticsDto> GovernorateRequests { get; set; }

    }
}
