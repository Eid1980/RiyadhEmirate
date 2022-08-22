
namespace Emirates.Core.Domain.Entities
{
    public class RequestTreatmentRecommendation
    {
        public Guid Id { get; set; }
        public int RequestTypeId { get; set; }
        public int PatientType { get; set; }
        public string PatientName { get; set; }
        public string PatientNationalId { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestType RequestType { get; set; }
    }
}
