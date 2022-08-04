
namespace Emirates.Core.Application.Models.Request.Authenticattion
{
    public class ValidateOTPModel
    {
        public string UserName { get; set; }
        public string OTP { get; set; }
    }
}
