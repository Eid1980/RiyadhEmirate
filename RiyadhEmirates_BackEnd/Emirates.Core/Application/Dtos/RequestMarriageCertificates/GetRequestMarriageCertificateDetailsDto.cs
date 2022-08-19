
namespace Emirates.Core.Application.Dtos
{
    public class GetRequestMarriageCertificateDetailsDto
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
        public string EmployeeSide { get; set; }
        public string JobOccupation { get; set; }
        public string MaritalStatusName { get; set; }
        public int ChildrenCount { get; set; }
        public int CreatedBy { get; set; }
    }
}
