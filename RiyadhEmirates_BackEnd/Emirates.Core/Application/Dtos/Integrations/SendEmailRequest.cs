
namespace Emirates.Core.Application.Dtos
{
    public class SendEmailRequest
    {
        public string EmailSubject { get; set; }
        public string Email { get; set; }
        public string EmailBody { get; set; }
    }
}
