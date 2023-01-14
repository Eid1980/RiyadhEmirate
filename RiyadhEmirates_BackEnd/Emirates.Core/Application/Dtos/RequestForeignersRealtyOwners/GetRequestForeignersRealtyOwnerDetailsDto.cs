
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestForeignersRealtyOwnerDetailsDto
    {
        public Guid Id { get; set; }
        public string RequestNumber { get; set; }
        public string ServiceName { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public bool CanEdit { get; set; }
        public string Notes { get; set; }
        public Guid ConcurrencyStamp { get; set; }

        public string BuildingTypeName { get; set; }
        public string GovernorateName { get; set; }
        public string District { get; set; }
        public string ReligionName { get; set; }
        public string Address { get; set; }
        public int CreatedBy { get; set; }
    }
}
