
namespace Emirates.Core.Application.Dtos
{
    public class GetServieNotificationListDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string StageName { get; set; }
        public bool IsSMS { get; set; }
        public bool IsEmail { get; set; }
        public bool IsActive { get; set; }

        public string Message { get; set; }
    }
}
