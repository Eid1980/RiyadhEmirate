
namespace Emirates.Core.Application.Dtos
{
    public class GetServieNotificationDetailsDto
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int StageId { get; set; }
        public string StageName { get; set; }
        public bool IsSMS { get; set; }
        public bool IsEmail { get; set; }
        public bool IsDefault { get; set; } = false;
        public bool IsActive { get; set; }

        public string Message { get; set; }
    }
}
