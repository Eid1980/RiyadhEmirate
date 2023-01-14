
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestStatisticsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string BackGroungColor { get; set; }
        public string BorderColor { get; set; }
    }

    public class ChartColors
    {
        public string BackGroungColor { get; set; }
        public string BorderColor { get; set; }
    }

    public class ServiceStageRequestStatistics
    {
        public List<string> Labels { get; set; }
        public List<ServiceStageRequestStatisticsDatasets> Datasets { get; set; }
    }
    public class ServiceStageRequestStatisticsDatasets
    {
        public string Label { get; set; }
        public List<int> Data { get; set; }
        public bool Fill { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public string PointBackgroundColor { get; set; }
        public string PointBorderColor { get; set; }
        public string PointHoverBackgroundColor { get; set; }
        public string PointHoverBorderColor { get; set; }
    }
}
