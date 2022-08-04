namespace Emirates.API.Extensions.Dtos.Request.Authentication
{
    public class ResetPasswordRequestDTO
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
    }
}
