
namespace Emirates.Core.Application.Dtos
{
    public class GetOpenDataCategueryListDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int OpenDataSubCategueryId { get; set; }
        public string OpenDataSubCategueryName { get; set; }
        public bool IsActive { get; set; }
    }
}
