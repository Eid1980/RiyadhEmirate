
namespace Emirates.Core.Application.Dtos
{
    public class CreateRequestTreatmentRecommendationDto
    {
        public int RequestTypeId { get; set; }
        public int PatientType { get; set; }
        public string PatientName { get; set; }
        public string PatientNationalId { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
    }
}
