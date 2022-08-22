
namespace Emirates.Core.Domain.Entities
{
    public class RequestForeignersRealtyOwner
    {
        public Guid Id { get; set; }
        public int BuildingTypeId { get; set; }
        public int GovernorateId { get; set; }
        public string District { get; set; }
        public int ReligionId { get; set; }
        public string Address { get; set; }


        public virtual Request Request { get; set; }
        public virtual BuildingType BuildingType { get; set; }
        public virtual Governorate Governorate { get; set; }
        public virtual Religion Religion { get; set; }
    }
}
