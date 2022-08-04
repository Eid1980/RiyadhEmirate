namespace Emirates.Core.Application.Models.Request.Authenticattion
{
    public class ResetPasswordDto
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
    }
}
