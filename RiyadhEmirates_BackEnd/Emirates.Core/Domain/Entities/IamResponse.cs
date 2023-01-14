
namespace Emirates.Core.Domain.Entities
{
    public class IamResponse
    {
        public Guid Id { get; set; }
        public string NationalId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }
        public int? HasIdExpired { get; set; }
        public DateTime? IdExpiryDate { get; set; }
        public string IdIssuePlaceCode { get; set; }
        public string IdIssuePlaceDescAr { get; set; }
        public string IdIssuePlaceDescEn { get; set; }
        public string IsGovernmentEmployee { get; set; }
        public string JobCategoryCode { get; set; }
        public string JobCategoryDescAr { get; set; }
        public string JobCategoryDescEn { get; set; }
        public string LifeStatusCode { get; set; }
        public string LifeStatusDescAr { get; set; }
        public string LifeStatusDescEn { get; set; }
        public int? SexCode { get; set; }
        public string MaritalStatusCode { get; set; }
        public string MaritalStatusDescAr { get; set; }
        public string MaritalStatusDescEn { get; set; }
    }
}
