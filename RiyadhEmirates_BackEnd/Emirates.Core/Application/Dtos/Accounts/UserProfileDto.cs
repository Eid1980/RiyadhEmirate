
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;

namespace Emirates.Core.Application.Dtos.Accounts
{
    public class UserProfileDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsMale { get; set; }
        public string BirthDate { get; set; }

        public int? NationalityId { get; set; }
        public string NationalityName { get; set; }
        public int? GovernorateId { get; set; }
        public string GovernorateName { get; set; }
        public string Address { get; set; }
        public string PassportId { get; set; }

        public UploadedFileBase64Model Image { get; set; }

    }
}
