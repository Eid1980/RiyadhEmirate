
namespace Emirates.Core.Application.Dtos
{
    public class GetEmiratesPrinceDetailsDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BehalfToAr { get; set; }
        public string BehalfToEn { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string ImageName { get; set; }
        public string Cv { get; set; }
        public bool IsActive { get; set; }
    }
}
