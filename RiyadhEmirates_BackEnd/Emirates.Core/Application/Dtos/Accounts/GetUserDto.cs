
namespace Emirates.Core.Application.Dtos
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public string EmployeeSide { get; set; }
        public int? ChildrenCount { get; set; }
        public string MaritalStatusName { get; set; }
        public string JobOccupation { get; set; }

        public string NationalId { get; set; }
        public string GenderName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string NationalityName { get; set; }
        public string GovernorateName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string OTP { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
