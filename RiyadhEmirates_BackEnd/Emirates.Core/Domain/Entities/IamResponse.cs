
namespace Emirates.Core.Domain.Entities
{
    public class IamResponse
    {
        public Guid Id { get; set; }
        public string NationalId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ArabicNationality { get; set; }
        public string Nationality { get; set; }

        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }

        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }

        public int? SexCode { get; set; }
        public string AssuranceLevel { get; set; }
        public string CardIssueDateGregorian { get; set; }
        public string CardIssueDateHijri { get; set; }

        public string IssueLocationAr { get; set; }
        public string IssueLocationEn { get; set; }
        public string IdIssuePlaceDescAr { get; set; }
        public string IdIssuePlaceDescEn { get; set; }

        public int? HasIdExpired { get; set; }
        public DateTime? IdExpiryDate { get; set; }
        public string IqamaExpirationDateH { get; set; }
        public string IdExpirationDateH { get; set; }

    }
}
