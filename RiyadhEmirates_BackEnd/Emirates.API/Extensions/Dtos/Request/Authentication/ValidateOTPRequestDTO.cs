namespace Emirates.API.Extensions.Dtos.Request.Authentication
{
    public class ValidateOTPRequestDTO
    {
        public string UserName { get; set; }
        public string OTP { get; set; }
    }
}
