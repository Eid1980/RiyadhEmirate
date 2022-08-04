using System.ComponentModel.DataAnnotations;

namespace Emirates.API.Extensions.Dtos.Request.Authentication
{
    public class ForgetPasswordRequestDTO
    {
        [Required]
        public string UserName { get; set; }
    }
}
