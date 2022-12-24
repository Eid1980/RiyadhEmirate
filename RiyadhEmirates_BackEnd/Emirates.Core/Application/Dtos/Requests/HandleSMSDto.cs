
namespace Emirates.Core.Application.Dtos
{
    public class HandleSMSDto
    {
        public int StageId { get; set; }
        public string RequestNumber { get; set; }
        public string ServiceName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string SmsMessage { get; set; }
        public string EmailMessage { get; set; }
    }
}
