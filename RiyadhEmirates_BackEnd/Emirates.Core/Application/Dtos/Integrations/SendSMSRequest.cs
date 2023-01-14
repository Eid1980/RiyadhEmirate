
namespace Emirates.Core.Application.Dtos
{
    public class SendSMSRequest
    {
        public string MobileNumber { get; set; }
        public string SmsBody { get; set; }
    }
}
