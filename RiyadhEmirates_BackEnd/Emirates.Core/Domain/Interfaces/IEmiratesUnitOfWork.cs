using Emirates.Core.Domain.Interfaces.Repositories;

namespace Emirates.Core.Domain.Interfaces
{
    public interface IEmiratesUnitOfWork : IUnitOfWork
    {
        IAuctionRepository Auctions { get; }
        IAudienceRepository Audiences { get; }
        ICaseTypeRepository CaseTypes { get; }
        ICommentStageRepository CommentStages { get; }
        IContactUsMessageRepository ContactUsMessages { get; }
        IDesignEvaluationRepository DesignEvaluations { get; }
        IEmiratesPrinceRepository EmiratesPrinces { get; }
        IGovernorateRepository Governorates { get; }
        INationalityRepository Nationalities { get; }
        INewsRepository News { get; }
        INewsCategueryRepository NewsCategueries { get; }
        INewsCommentRepository NewsComments { get; }
        IOpenDataCategueryRepository OpenDataCategueries { get; }
        IOpenDataReportRepository OpenDataReports { get; }
        IOpenDataRequestRepository OpenDataRequests { get; }
        IPageMainPointsRepository PageMainPoints { get; }
        IPageContentRepository PageContent { get; }
        IPosterRepository Posters { get; }
        IPrisonRepository Prisons { get; }
        IRequestRepository Requests { get; }
        IRequestAttachmentTypeRepository RequestAttachmentTypes { get; }
        IRequestElectronicBoardRepository RequestElectronicBoards { get; }
        IRequestElectronicSummonRepository RequestElectronicSummons { get; }
        IRequestForeignersRealtyOwnerRepository RequestForeignersRealtyOwners { get; }
        IRequestJudgmentExecutionRepository RequestJudgmentExecutions { get; }
        IRequestLandsInfringementRepository RequestLandsInfringements { get; }
        IRequestMarriageCertificateRepository RequestMarriageCertificates { get; }
        IRequestPrisonersServiceRepository RequestPrisonersServices { get; }
        IRequestPrisonerTempReleaseRepository RequestPrisonerTempReleases { get; }
        IRequestStageLogRepository RequestStageLogs { get; }
        IRequestTreatmentRecommendationRepository RequestTreatmentRecommendations { get; }
        IRequestTypeRepository RequestTypes { get; }
        IRoleRepository Roles { get; }
        IServiceAudienceRepository ServiceAudiences { get; }
        IServiceBenefitRepository ServiceBenefits { get; }
        IServiceConditionRepository ServiceConditions { get; }
        IServiceRateRepository ServiceRates { get; }
        IServiceRepository Services { get; }
        IServiceStageRepository ServiceStages { get; }
        IServieNotificationRepository ServieNotifications { get; }
        IServieNotificationLogRepository ServieNotificationLogs { get; }
        IStageRepository Stages { get; }
        IUploadedFileRepository UploadedFiles { get; }
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }
        ILookupRepository Lookups { get; }
    }
}
