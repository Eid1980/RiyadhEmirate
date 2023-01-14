
namespace Emirates.Core.Domain.Entities
{
    public class RequestJudgmentExecution
    {
        public Guid Id { get; set; }
        public int RequesterType { get; set; }
        public string RequesterName { get; set; }
        public string RequesterNationalId { get; set; }

        public int DefendantTypeId { get; set; }
        public string LawsuitNumber { get; set; }
        public DateTime LawsuitDate { get; set; }

        public virtual Request Request { get; set; }
        public virtual DefendantType DefendantType { get; set; }
    }
}
