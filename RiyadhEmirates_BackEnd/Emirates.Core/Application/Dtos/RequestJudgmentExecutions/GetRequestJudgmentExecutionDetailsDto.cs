
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestJudgmentExecutionDetailsDto
    {
        public Guid Id { get; set; }
        public string RequestNumber { get; set; }
        public string ServiceName { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public bool CanEdit { get; set; }
        public string Notes { get; set; }
        public Guid ConcurrencyStamp { get; set; }

        public string RequesterTypeName { get; set; }
        public string RequesterName { get; set; }
        public string RequesterNationalId { get; set; }
        public string DefendantTypeName { get; set; }
        public string LawsuitNumber { get; set; }
        public string LawsuitDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
