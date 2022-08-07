
using System.ComponentModel.DataAnnotations;

namespace Emirates.Core.Application.Dtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "اسم المستخدم الزامي")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "كلمة المرور الزامية")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "تأكيد كلمة المرور الزامية")]
        [Compare(nameof(PassWord), ErrorMessage = "كلمة المرور غير متطابقة")]
        public string ConfirmPassWord { get; set; }

        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }

        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }

        public string EmployeeSide { get; set; }
        public int? ChildrenCount { get; set; }
        public int? MaritalStatusId { get; set; }
        public string JobOccupation { get; set; }

        public bool IsMale { get; set; }
        [EmailAddress(ErrorMessage ="صيغة البريد الالكتروني غير صحيحة")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string PassportId { get; set; }
        public DateTime BirthDate { get; set; }

        public int? NationalityId { get; set; }
        public int? GovernorateId { get; set; }
        public DateTime? IdentityExpireDate { get; set; }
        public string Address { get; set; }
    }
}
