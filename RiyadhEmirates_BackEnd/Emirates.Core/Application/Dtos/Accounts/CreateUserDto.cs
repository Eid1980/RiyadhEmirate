
namespace Emirates.Core.Application.Dtos
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
