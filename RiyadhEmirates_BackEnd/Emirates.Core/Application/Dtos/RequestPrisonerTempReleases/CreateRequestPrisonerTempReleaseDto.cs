
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestPrisonerTempReleaseDto
    {
        public int RequestTypeId { get; set; }
        public int PrisonId { get; set; }
        public int CaseTypeId { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
