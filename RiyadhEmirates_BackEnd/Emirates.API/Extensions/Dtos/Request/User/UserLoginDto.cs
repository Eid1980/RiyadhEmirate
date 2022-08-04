using System.ComponentModel.DataAnnotations;

namespace Emirates.API.Dtos.Request.User
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
