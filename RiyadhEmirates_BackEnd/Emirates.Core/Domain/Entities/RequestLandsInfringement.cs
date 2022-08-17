
namespace Emirates.Core.Domain.Entities
{
    public class RequestLandsInfringement
    {
        public Guid Id { get; set; }
        public int RequestTypeId { get; set; }
        public string InstrumentNumber { get; set; }
        public string EstimatedSpace { get; set; }
        public int GovernorateId { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string InfringerName { get; set; }
        public string InfringerDescription { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual Governorate Governorate { get; set; }
    }
}
