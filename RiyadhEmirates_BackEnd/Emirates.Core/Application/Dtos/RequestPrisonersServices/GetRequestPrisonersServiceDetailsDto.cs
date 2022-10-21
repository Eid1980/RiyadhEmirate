
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestPrisonersServiceDetailsDto
    {
        public Guid Id { get; set; }
        public string RequestNumber { get; set; }
        public string ServiceName { get; set; }
        public string RequestDate { get; set; }
        public string StageName { get; set; }
        public bool CanEdit { get; set; }
        public string Notes { get; set; }
        public Guid ConcurrencyStamp { get; set; }

        public string RequestTypeName { get; set; }
        public int PrisonId { get; set; }
        public string PrisonName { get; set; }
        public string CaseTypeName { get; set; }
        public int CreatedBy { get; set; }
    }
}
