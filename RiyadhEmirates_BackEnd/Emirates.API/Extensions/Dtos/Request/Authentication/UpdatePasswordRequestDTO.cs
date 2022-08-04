using System.ComponentModel.DataAnnotations;

namespace Emirates.API.Extensions.Dtos.Request.Authentication
{
    public class UpdatePasswordRequestDTO
    {
        [Required]
        public string OldPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
