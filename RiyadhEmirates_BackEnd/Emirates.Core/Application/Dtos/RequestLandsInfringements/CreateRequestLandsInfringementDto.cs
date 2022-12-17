
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestLandsInfringementDto
    {
        public int RequestTypeId { get; set; }
        public string EstimatedSpace { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string InfringerName { get; set; }
        public string InfringerDescription { get; set; }

        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
