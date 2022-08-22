
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestForeignersRealtyOwnerDto
    {
        public int BuildingTypeId { get; set; }
        public int GovernorateId { get; set; }
        public string District { get; set; }
        public int ReligionId { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
