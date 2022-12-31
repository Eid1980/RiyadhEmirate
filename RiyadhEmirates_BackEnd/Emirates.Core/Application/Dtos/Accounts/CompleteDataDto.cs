
namespace Emirates.Core.Application.Dtos
{
    public class CompleteDataDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? NationalityId { get; set; }
        public int? GovernorateId { get; set; }
        public string Address { get; set; }
    }
}
