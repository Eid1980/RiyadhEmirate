
namespace Emirates.Core.Application.Dtos.ServiceRates
{
    public class GetServiceRateDto
    {
        public int ServiceRate { get; set; }
        public bool CanRate { get; set; }
        public int RateCout { get; set; }
        public string LastRateDate { get; set; }
        public double ServiceRatePercentage { get; set; }
        public string RatePercentage { get; set; }
    }
}
