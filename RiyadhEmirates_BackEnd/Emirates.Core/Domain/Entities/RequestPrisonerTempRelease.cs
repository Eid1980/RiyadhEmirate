
namespace Emirates.Core.Domain.Entities
{
    public class RequestPrisonerTempRelease
    {
        public Guid Id { get; set; }
        public int RequestTypeId { get; set; }
        public string PresonName { get; set; }
        public int CaseTypeId { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual CaseType CaseType { get; set; }
    }
}
