
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestMarriageCertificateDto
    {
        public int RequestTypeId { get; set; }
        public string EmployeeSide { get; set; }
        public string JobOccupation { get; set; }
        public int MaritalStatusId { get; set; }
        public int ChildrenCount { get; set; }

        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
