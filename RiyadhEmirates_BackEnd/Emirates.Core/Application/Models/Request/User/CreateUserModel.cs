namespace Emirates.Core.Application.Models.Request.User
{
    public class CreateUserModel
    {
        public string Name { get; set; }
        public string NationalId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
