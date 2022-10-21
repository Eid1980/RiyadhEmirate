
namespace Emirates.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FirstNameAr { get; set; }
        public string SecondNameAr { get; set; }
        public string ThirdNameAr { get; set; }
        public string LastNameAr { get; set; }

        public string FirstNameEn { get; set; }
        public string SecondNameEn { get; set; }
        public string ThirdNameEn { get; set; }
        public string LastNameEn { get; set; }

        public bool IsMale { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; } = true;
        public string PassportId { get; set; }

        public int? NationalityId { get; set; }
        public DateTime? IdentityExpireDate { get; set; }
        public string Address { get; set; }

        public bool IsEmployee { get; set; }
        public bool IsActive { get; set; }

        public string Last2Factor { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public virtual Nationality Nationality { get; set; }

        public virtual ICollection<BuildingType> CreatedBuildingTypes { get; set; }
        public virtual ICollection<BuildingType> ModifiedBuildingTypes { get; set; }

        public virtual ICollection<Audience> CreatedAudiences { get; set; }
        public virtual ICollection<Audience> ModifiedAudiences { get; set; }

        public virtual ICollection<Prison> CreatedPrisons { get; set; }
        public virtual ICollection<Prison> ModifiedPrisons { get; set; }

        public virtual ICollection<CaseType> CreatedCaseTypes { get; set; }
        public virtual ICollection<CaseType> ModifiedCaseTypes { get; set; }

        public virtual ICollection<DefendantType> CreatedDefendantTypes { get; set; }
        public virtual ICollection<DefendantType> ModifiedDefendantTypes { get; set; }

        public virtual ICollection<Nationality> CreatedNationalities { get; set; }
        public virtual ICollection<Nationality> ModifiedNationalities { get; set; }

        public virtual ICollection<Service> CreatedServices { get; set; }
        public virtual ICollection<Service> ModifiedServices { get; set; }

        public virtual ICollection<RequestAttachmentType> CreatedRequestAttachmentTypes { get; set; }
        public virtual ICollection<RequestAttachmentType> ModifiedRequestAttachmentTypes { get; set; }
        
        public virtual ICollection<RequestType> CreatedRequestTypes { get; set; }
        public virtual ICollection<RequestType> ModifiedRequestTypes { get; set; }

        public virtual ICollection<Request> CreatedRequests { get; set; }
        public virtual ICollection<Request> ModifiedRequests { get; set; }

        public virtual ICollection<Stage> CreatedStages { get; set; }
        public virtual ICollection<Stage> ModifiedStages { get; set; }

        public virtual ICollection<RequestStageLog> CreatedRequestStageLogs { get; set; }
        public virtual ICollection<RequestStageLog> ModifiedRequestStageLogs { get; set; }

        public virtual ICollection<Role> CreatedRoles { get; set; }
        public virtual ICollection<Role> ModifiedRoles { get; set; }

        public virtual ICollection<UploadedFile> CreatedUploadedFiles { get; set; }
        public virtual ICollection<UploadedFile> ModifiedUploadedFiles { get; set; }

        public virtual ICollection<News> CreatedNews { get; set; }
        public virtual ICollection<News> ModifiedNews { get; set; }

        public virtual ICollection<NewsCateguery> CreatedNewsCategueries { get; set; }
        public virtual ICollection<NewsCateguery> ModifiedNewsCategueries { get; set; }

        public virtual ICollection<ServiceRate> CreatedServiceRates { get; set; }

        public virtual ICollection<Governorate> CreatedGovernorates { get; set; }
        public virtual ICollection<Governorate> ModifiedGovernorates { get; set; }

        public virtual ICollection<MaritalStatus> CreatedMaritalStatuses { get; set; }
        public virtual ICollection<MaritalStatus> ModifiedMaritalStatuses { get; set; }

        public virtual ICollection<ServiceStage> CreatedServiceStages { get; set; }
        public virtual ICollection<ServiceStage> ModifiedServiceStages { get; set; }

        public virtual ICollection<Poster> CreatedPosters { get; set; }
        public virtual ICollection<Poster> ModifiedPosters { get; set; }

        public virtual ICollection<Religion> CreatedReligions { get; set; }
        public virtual ICollection<Religion> ModifiedReligions { get; set; }

        public virtual ICollection<ServiceAudience> CreatedServiceAudiences { get; set; }

        public virtual ICollection<ServiceCondition> CreatedServiceConditions { get; set; }
        public virtual ICollection<ServiceCondition> ModifiedServiceConditions { get; set; }

        public virtual ICollection<NewsComment> ModifiedNewsComments { get; set; }

        public virtual ICollection<CommentStage> CreatedCommentStages { get; set; }
        public virtual ICollection<CommentStage> ModifiedCommentStages { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserRole> CreatedUserRoles { get; set; }
        public virtual ICollection<UserRole> ModifiedUserRoles { get; set; }

        public virtual ICollection<EmiratesPrince> CreatedEmiratesPrinces { get; set; }
        public virtual ICollection<EmiratesPrince> ModifiedEmiratesPrinces { get; set; }

        public virtual ICollection<ContactUsMessage> ModifiedContactUsMessages { get; set; }
        public virtual ICollection<OpenDataRequest> ModifiedOpenDataRequests { get; set; }

        public virtual ICollection<Auction> CreatedAuctions { get; set; }
        public virtual ICollection<Auction> ModifiedAuctions { get; set; }

        public virtual ICollection<OpenDataSubCateguery> CreatedOpenDataSubCategueries { get; set; }
        public virtual ICollection<OpenDataSubCateguery> ModifiedOpenDataSubCategueries { get; set; }

        public virtual ICollection<OpenDataCateguery> CreatedOpenDataCategueries { get; set; }
        public virtual ICollection<OpenDataCateguery> ModifiedOpenDataCategueries { get; set; }

        public virtual ICollection<OpenDataReport> CreatedOpenDataReports { get; set; }
        public virtual ICollection<OpenDataReport> ModifiedOpenDataReports { get; set; }

    }
}
