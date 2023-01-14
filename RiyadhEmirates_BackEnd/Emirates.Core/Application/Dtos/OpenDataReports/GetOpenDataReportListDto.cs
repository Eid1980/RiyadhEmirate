
namespace Emirates.Core.Application.Dtos
{
    public class GetOpenDataReportListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataCategueryId { get; set; }
        public string OpenDataCategueryName { get; set; }
        public bool IsActive { get; set; }
    }
}
