
namespace Emirates.Core.Application.Dtos.Requests
{
    public class GetElectronicConcilInboxDto
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string RequestNumber { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public string Notes { get; set; }
        public string Url { get; set; }
        public string RequestTitle { get; set; }
        public string RequestContent { get; set; }
        public string RequestTypeName { get; set; }
        public int ServiceId { get; set; }
        public int StageId { get; set; }
        public string NationalId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
