
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestLandsInfringementDetailsDto
    {
        public Guid Id { get; set; }
        public string RequestNumber { get; set; }
        public string ServiceName { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public bool CanEdit { get; set; }
        public string Notes { get; set; }
        public Guid ConcurrencyStamp { get; set; }

        public string RequestTypeName { get; set; }
        public string InstrumentNumber { get; set; }
        public string EstimatedSpace { get; set; }
        public string GovernorateName { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LocationLink { get; set; }
        public string InfringerName { get; set; }
        public string InfringerDescription { get; set; }
        public int CreatedBy { get; set; }
    }
}
