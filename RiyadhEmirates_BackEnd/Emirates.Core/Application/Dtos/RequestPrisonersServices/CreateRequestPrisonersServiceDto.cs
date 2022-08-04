
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestPrisonersServiceDto
    {
        public int RequestTypeId { get; set; }
        public string PresonName { get; set; }
        public int CaseTypeId { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
