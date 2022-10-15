
namespace Emirates.Core.Application.Dtos
{
    public class GetOpenDataReportDetailsDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataCategueryId { get; set; }
        public string OpenDataCategueryName { get; set; }
        public string FileUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
