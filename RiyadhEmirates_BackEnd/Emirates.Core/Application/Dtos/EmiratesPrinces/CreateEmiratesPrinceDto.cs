
namespace Emirates.Core.Application.Dtos
{
    public class CreateEmiratesPrinceDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BehalfToAr { get; set; }
        public string BehalfToEn { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool IsActive { get; set; }
    }
}
