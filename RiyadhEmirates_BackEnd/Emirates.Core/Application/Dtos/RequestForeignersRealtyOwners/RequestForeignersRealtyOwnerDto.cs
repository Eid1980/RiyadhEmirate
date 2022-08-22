
namespace Emirates.Core.Application.Dtos
{
    public class RequestForeignersRealtyOwnerDto : CreateRequestForeignersRealtyOwnerDto
    {
        public bool CanEdit { get; set; }
        public Guid ConcurrencyStamp { get; set; }
        public int CreatedBy { get; set; }
    }
}
