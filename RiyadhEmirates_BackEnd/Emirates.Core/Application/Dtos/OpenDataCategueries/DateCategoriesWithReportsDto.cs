
namespace Emirates.Core.Application.Dtos.OpenDataCategueries
{
    public class DateCategoriesWithReportsDto
    {
        public int CategpryId { get; set; }
        public string CategoryName { get; set; }
        public List<GetOpenDataReportDetailsDto> DataReportDetails { get; set; }
    }
}
