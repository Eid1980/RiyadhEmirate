
namespace Emirates.Core.Application.Dtos
{
    public class CreateOpenDataReportDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataCategueryId { get; set; }
        public string FileUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
