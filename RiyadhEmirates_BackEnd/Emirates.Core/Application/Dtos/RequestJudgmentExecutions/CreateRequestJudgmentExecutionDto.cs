
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestJudgmentExecutionDto
    {
        public int RequesterType { get; set; }
        public string RequesterName { get; set; }
        public string RequesterNationalId { get; set; }

        public int DefendantTypeId { get; set; }
        public string LawsuitNumber { get; set; }
        public DateTime LawsuitDate { get; set; }

        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
