
namespace Emirates.Core.Application.Dtos
{
    public class GetUserDataDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }

        public string GenderName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string NationalityName { get; set; }
        public string GovernorateName { get; set; }
    }
}
