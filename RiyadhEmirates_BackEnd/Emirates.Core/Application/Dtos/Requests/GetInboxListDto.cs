
namespace Emirates.Core.Application.Dtos
{
    public class GetInboxListDto
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string RequestNumber { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public string Notes { get; set; }
        public string Url { get; set; }

        public int ServiceId { get; set; }
        public int StageId { get; set; }
        public string NationalId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
